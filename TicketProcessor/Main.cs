using Configurations;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddControllers();
builder.Services.AddHttpClient();

// Configuração do PostgreSQL (agora em arquivo separado)
builder.Services.AddPostgreSQLConfiguration(builder.Configuration);

var app = builder.Build();

// Testar conexão com o banco
app.TestDatabaseConnection();

// Configuração do pipeline
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");

app.Run();