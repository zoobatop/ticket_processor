using TicketProcessor.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Configuração do PostgreSQL
var connectionString = builder.Configuration.GetConnectionString("PostgreSQL");
if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(connectionString));
    
    Console.WriteLine("Configuração do PostgreSQL adicionada.");
}
else
{
    Console.WriteLine("String de conexão PostgreSQL não encontrada.");
}

var app = builder.Build();

// Testar conexão com o banco antes de iniciar
if (!string.IsNullOrEmpty(connectionString))
{
    try
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        
        if (dbContext.Database.CanConnect())
        {
            Console.WriteLine("Conexão com PostgreSQL estabelecida com sucesso");
        }
        else
        {
            Console.WriteLine("Não foi possível conectar ao PostgreSQL");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao testar conexão com PostgreSQL: {ex.Message}");
    }
}

// Configuração do pipeline
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();