using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Laboratorio11.Models;
using Laboratorio11.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BdContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DafaultConnection"));
    options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
});
builder.Services.AddScoped<IAutorRepository, AutorRepositoryEF>(); //(interface, objeto da implementação da interface)
//builder.Services.AddScoped<ILivroRepository, LivroRepositoryEF>();
//builder.Services.AddScoped<IEmprestimoRepository, EmprestimoRepositoryEF>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
    builder => builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader()
    );
});*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

//app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
