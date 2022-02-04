using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository.Context;
using Repository.Interface;
using Repository.JwtAuthentication.Helpers;
using Repository.JwtAuthentication.Services;
using Repository.Repositories;
using Repository.AuthHelper;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;


builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(configuration.GetConnectionString("MainConnection")));
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("MainConnection")));
//Change Password Role Policy
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 4;
    options.Password.RequiredUniqueChars = 0;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = true;

});
builder.Services.Configure<SecurityStampValidatorOptions>(options =>
{
    // enables immediate logout, after updating the user's stat.
    options.ValidationInterval = TimeSpan.Zero;
});
// configure strongly typed settings object
builder.Services.Configure<AppSettings>(configuration.GetSection("AppSettings"));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
#region InJectes
builder.Services.AddScoped<IAspNetUserClaimsRepository, AspNetUserClaimsRepository>();
builder.Services.AddScoped<IAspNetUsersRepository, AspNetUsersRepository>();

//------------- API  TicketTI----------------

builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

builder.Services.AddSingleton<IAuthorizationPolicyProvider, CheckAccessPolicyProvider>();
builder.Services.AddScoped<IUserService, UserService>();

#endregion

var app = builder.Build();
app.UseHttpsRedirection();

// global cors policy
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();
//// custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();


app.MapControllers();

app.Run();