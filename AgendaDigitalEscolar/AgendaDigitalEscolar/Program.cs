using Entidades;
using Microsoft.EntityFrameworkCore;
using Repositorios;
using Repositorios.Contexto;
using Repositorios.Interfaces;
using Services;
using Services.DTO;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(DtoMappingProfile));

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
                                             options.UseMySql(mySqlConnection,
                                             ServerVersion.AutoDetect(mySqlConnection)));


builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();

builder.Services.AddScoped(typeof(IBaseRepositorio<>), typeof(BaseRepositorio<>));

builder.Services.AddScoped<IEscolasServices, EscolasServices>();
builder.Services.AddScoped<IComunicadoServices, ComunicadosServices>();
builder.Services.AddScoped<IResponsavelServices, ResponsavelServices>();
//builder.Services.AddScoped<IEventoServices, EventoServices>();
//builder.Services.AddScoped<IProfessorServices, ProfessorServices>();
//builder.Services.AddScoped<IAlunoServices, AlunoServices>();
builder.Services.AddScoped<IAgendaDiariaServices, AgendaDiariaServices>();
//builder.Services.AddScoped<IAtividadeServices, AtividadeServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
