
using Repository.Class;
using Repository.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IAspNetUsersRepository
    {
        Task RefreshSignIn(ApplicationUser user);
        Task<string> GetFullName(string userId);
        Task<bool> IsUserNameUnique(string userName);
        Task<bool> IsEconomicCodeUnique(string EconomicCode);
        Task<bool> IsEmailUnique(string Email);
        Task<bool> IsNationalCodeUnique(string NationalCode);
        Task<bool> IsEconomicCodeUnique(string userId, string EconomicCode);
        Task<bool> IsEmailUnique(string userId, string Email);
        Task<bool> IsNationalCodeUnique(string userId, string NationalCode);
        Task<string> GetPhoneNumber(ApplicationUser user);
        Task<List<ApplicationUser>> GetAll();

        Task<ApplicationUser> GetById(string userId);
        Task<ApplicationUser> GetByUserName(string userName);
        Task<ApplicationUser> GetUser(ClaimsPrincipal user);
        Task<GeneralResponse> Edit(ApplicationUser item);
        Task<GeneralResponse> Delete(string userId);
        Task<List<ApplicationUser>> GetByIds(string ids, string customerType);
        Task<GeneralResponse> UpdateIsDocVerify(string userId, bool isDocVerify);
    }
}
