using ClientCompanyBusiness.Repository;
using ClientCompanyDataAccess.Client;
using ClientCompanyDataAccess.Company;
using ClientCompanyDataAccess.Employee;
using ClientCompanyDataAccess.Request;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SqliteDbContext>(options => options.UseSqlite(Environment.GetEnvironmentVariable("DatabaseConnection")));

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


