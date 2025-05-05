using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Data;

namespace Configurations
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection AddPostgreSQLConfiguration(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PostgreSQL");
            
            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("String de conexão PostgreSQL não encontrada. A aplicação continuará sem acesso ao banco de dados.");
                return services;
            }

            try
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseNpgsql(connectionString, npgsqlOptions =>
                    {
                        npgsqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 3,
                            maxRetryDelay: TimeSpan.FromSeconds(5),
                            errorCodesToAdd: null);
                    }));

                services.AddHealthChecks()
                    .AddDbContextCheck<AppDbContext>("PostgreSQL");

                Console.WriteLine("Configuração do PostgreSQL concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao configurar o PostgreSQL: {ex.Message}. A aplicação continuará sem acesso ao banco de dados.");
            }

            return services;
        }

        public static void TestDatabaseConnection(this WebApplication app)
        {
            try
            {
                using var scope = app.Services.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                
                if (dbContext.Database.CanConnect())
                {
                    Console.WriteLine("Conexão com o PostgreSQL estabelecida com sucesso.");
                }
                else
                {
                    Console.WriteLine("Não foi possível conectar ao PostgreSQL. A aplicação continuará sem acesso ao banco de dados.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao testar conexão com PostgreSQL: {ex.Message}. A aplicação continuará sem acesso ao banco de dados.");
            }
        }
    }
}