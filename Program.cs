using Microsoft.EntityFrameworkCore;
using GsDotNet.Data;
using GsDotNet.Repositories.Interfaces;
using GsDotNet.Repositories.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Configura��o da conex�o com o Oracle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

// Registro dos reposit�rios na inje��o de depend�ncia
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IConsumoRepository, ConsumoRepository>();
builder.Services.AddScoped<IHistoricoConsumoRepository, HistoricoConsumoRepository>();
builder.Services.AddScoped<IFeedbackConsumoRepository, FeedbackConsumoRepository>();

// Adicionar servi�os ao cont�iner
builder.Services.AddControllers();

// Configura��o do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura��o do pipeline de requisi��o HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
