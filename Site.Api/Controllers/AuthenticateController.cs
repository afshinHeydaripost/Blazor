using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Identity;
using Repository.ViewModels;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Repository.Interface;

using System.Text;
using Repository.JwtAuthentication.Models;
using RPCoreLib;
using Repository.Class;
using Repository.JwtAuthentication.Services;

namespace Site.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        #region Ctor
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IAspNetUsersRepository _aspNetUsersRep;
        private readonly IUserService _userService;
        public AuthenticateController(IConfiguration configuration,
            IAspNetUsersRepository aspNetUsersRep, IUserService userService,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _configuration = configuration;
            _aspNetUsersRep = aspNetUsersRep;
            _userService = userService;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        #endregion

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest model)
        {
            //sanitizer texts
            model.Username = model.Username.ToSafeString();
            model.Password = model.Password.ToSafeString();
            string decodedString;
            try
            {
                byte[] decodedPass = Convert.FromBase64String(model.Password);
                decodedString = Encoding.UTF8.GetString(decodedPass);

            }
            catch (Exception e)
            {
                return Ok(new GeneralResponse() { IsSuccess = false, Message = Message.InvalidData, ErrorMessage = e.Message + e.InnerException != null ? e.InnerException.Message : "" });
            }


            var user = await _aspNetUsersRep.GetByUserName(model.Username);

            // return null if user not found
            if (user == null) return Ok(new GeneralResponse() { IsSuccess = false, Message = Message.NotFound });


            var passwordCheckRes = await _signInManager.PasswordSignInAsync(model.Username, decodedString, false, lockoutOnFailure: false);
            if (!passwordCheckRes.Succeeded) return Ok(new GeneralResponse() { IsSuccess = false, Message = "نام کاربری یا کلمه عبور اشتباه است" });

            if (!user.UserStatus) return Ok(new GeneralResponse() { IsSuccess = false, Message = Message.UserIsNotActive });

            var response = _userService.Authenticate(user);

            if (response.obj == null) return Ok(response);

            return Ok(response);
        }

        #region private

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        #endregion
    }
}
