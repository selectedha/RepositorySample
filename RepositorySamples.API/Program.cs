using Microsoft.EntityFrameworkCore;
using RepositorySamples.DAL;
using RepositorySamples.Domain.Common;
using RepositorySamples.DAL.Common;
using RepositorySamples.Domain.Categories;
using RepositorySamples.API.Categories;
using RepositorySamples.Domain.Products;
using RepositorySamples.API.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RepSampleDBContext>(c => c.UseSqlServer("Password=h0t@@TL7X5At;User ID=ha;Initial Catalog=Repo;Data Source=db.avang.ir\\devops"));
builder.Services.AddScoped<IRepositorySampleDomainUnitOfWork, EFRepositorySampleDomainUnitOfWork>();
builder.Services.AddScoped<ICategoryRepository, EfCategoryRepository>();
builder.Services.AddScoped<IProductRepository, EfProductRepository>();

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
