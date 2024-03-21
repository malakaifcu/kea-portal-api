using LoanPortalAPIDev;
using LoanPortalAPIDev.Data;
using LoanPortalAPIDev.Filters;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.ComponentModel;
using System.Reflection;
using System.Security.Claims;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Kea API",
        Description = "An ASP.NET Core Web API for managing the KEA portal items"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Scheme = "Bearer"

    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement() {
        {
        new OpenApiSecurityScheme()
        {
            Reference = new OpenApiReference{
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            },
            Scheme = "oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header
        },
        new List<string>()
        }
        
    });
    options.CustomSchemaIds(type => type.FullName?.Replace("+","."));
    options.DocumentFilter<CustomDocumentFilter>();

    options.OperationFilter<SecurityRequirementsOperationFilter>();

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

//Db context using in memory DB for test purposes
//var connectionString = "";
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("AppDb"));
builder.Services.AddDbContext<AppPostgresDbContext>(options => options.UseNpgsql("WebApiDatabase"));

builder.Services.AddAuthorization();

builder.Services.AddIdentityApiEndpoints<MyUser>()
    .AddEntityFrameworkStores<AppDbContext>();

//builder.Services.AddIdentityCore<MyUser>()
//    .AddEntityFrameworkStores<AppDbContext>();

//Build app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseSwaggerUI(options => {
    //    options.InjectStylesheet("/theme-outline.css");
    //    options.SwaggerEndpoint("./v1/swagger.json", "FCU Loan Portal API");
    //});
}


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseCors("Open");

//app.MapSwagger().RequireAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}"
    );

app.MapGroup("/api")
    .MapIdentityApi<MyUser>();

                                           

app.Run();
