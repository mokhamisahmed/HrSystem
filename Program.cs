using AutoMapper;
using HRSystem.Database;
using HRSystem.Models;
using HRSystem.Repositories;
using HRSystem.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Connection>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("connection"))
    );

builder.Services.AddScoped<Connection, Connection>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Connection>();
builder.Services.AddScoped<RoleManager<IdentityRole>, RoleManager<IdentityRole>>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped <ICrud<Attendance>,CrudService<Attendance>>();

builder.Services.AddScoped<ILeave, LeaveService>();

builder.Services.AddScoped<IRegistration,RegistrationService>();

builder.Services.AddScoped<IProfile,PersonalService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
