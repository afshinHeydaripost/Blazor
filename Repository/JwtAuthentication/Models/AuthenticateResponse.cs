using Repository.JwtAuthentication.Entities;
using Repository.Identity;

namespace JwtAuthentication.ApiClasses.Models
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public bool IsDocVerify { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(ApplicationUser user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.UserName;
            IsDocVerify = user.IsDocVerify;
            Token = token;
        }
    }
}
