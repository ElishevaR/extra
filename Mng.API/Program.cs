using Mng.Core.IRepositories;
using Mng.Core.IServices;
using Mng.Data.Repositories;
using Mng.Data;
using Mng.Service.Services;
using Microsoft.EntityFrameworkCore;
using Mng.Core;
using Mng.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(@"Server=DESKTOP-24EQMFH;Data Source=DESKTOP-24EQMFH;Initial Catalog=Mng_project;Integrated Security=true; User ID=YD;Password=1234; TrustServerCertificate=True; Encrypt=False;"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
  options.AddDefaultPolicy(policy =>
  {
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
  });
});
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IRoleForEmployeeService, RoleForEmployeeService>();
builder.Services.AddScoped<IRoleForEmployeeRepository, RoleForEmployeeRepository>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IRoleRepositoy,RoleRepository>();
builder.Services.AddAutoMapper(typeof(MappingProfileDTO), typeof(MappingProfileModels));
builder.Services.AddDbContext<DataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
