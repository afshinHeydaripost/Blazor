using JwtAuthentication.ApiClasses.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Repository.Class;
using Repository.Identity;
using Repository.Interface;
using Repository.JwtAuthentication.Helpers;
using Repository.JwtAuthentication.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository.JwtAuthentication.Services
{
    public interface IUserService
    {
        GeneralResponse<AuthenticateResponse> Authenticate(ApplicationUser user);
        Task<List<ApplicationUser>> GetAll();
        Task<ApplicationUser> GetById(string id);
        string GenerateJwtToken(ApplicationUser user);
    }

    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications


        private readonly AppSettings _appSettings;
        private readonly IAspNetUsersRepository _users;

        public UserService(IOptions<AppSettings> appSettings, IAspNetUsersRepository users)
        {
            _appSettings = appSettings.Value;
            _users = users;
        }

        public GeneralResponse<AuthenticateResponse> Authenticate(ApplicationUser user)
        {
            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new GeneralResponse<AuthenticateResponse>() { IsSuccess = true, Message = "ورود با موفقیت انجام شد.", obj = new AuthenticateResponse(user, token) };
        }

        public string GenerateJwtToken(ApplicationUser user)
        {
            // return null if user not found
            if (user == null) return null;
            return generateJwtToken(user);

        }

        public async Task<List<ApplicationUser>> GetAll()
        {
            return await _users.GetAll();
        }

        public async Task<ApplicationUser> GetById(string id)
        {
            return await _users.GetById(id);
        }

        // helper methods

        private string generateJwtToken(ApplicationUser user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("Id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddMinutes(20),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}