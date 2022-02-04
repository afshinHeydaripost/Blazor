using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.Class;
using Repository.Context;
using Repository.Identity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Repository.Repositories
{

    public class AspNetUsersRepository : IAspNetUsersRepository
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly DataBaseContext _Context;
        private readonly UserManager<ApplicationUser> _userManager;
        public AspNetUsersRepository(DataBaseContext Context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _Context = Context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<GeneralResponse> Delete(string userId)
        {
            var res = new GeneralResponse();
            var user = await GetById(userId);
            if (user == null)
            {
                res.Message = Message.NotFound;
                return res;
            }
            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    res.Message += item.Description + "\r\n";
                }
                return res;
            }
            res.Message = Message.SubmitSuccessDelete;
            res.IsSuccess = true;
            return res;
        }
        public async Task<GeneralResponse> UpdateIsDocVerify(string userId, bool isDocVerify)
        {
            var res = new GeneralResponse();
            try
            {
                var user = await GetById(userId);
                if (user == null)
                {
                    res.Message = Message.NotFound;
                    return res;
                }
                user.IsDocVerify = isDocVerify;
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        res.Message += item.Description + "\r\n";
                    }
                    return res;
                }
                res.Message = Message.SubmitSuccess;
                res.IsSuccess = true;
                return res;
            }
            catch (Exception e)
            {
                res.Message = Message.SubmitError;
                res.ErrorMessage = e.Message;
                return res;
            }
        }
        public async Task<GeneralResponse> Edit(ApplicationUser applicationUser)
        {
            var res = new GeneralResponse();
            var result = await _userManager.UpdateAsync(applicationUser);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    res.ErrorMessage = error.Description + "\r\n";
                }
                res.Message = Message.SubmitError;
                return res;
            }
            res.Message = Message.SubmitSuccess;
            res.IsSuccess = true;
            return res;
        }
        public async Task<List<ApplicationUser>> GetAll()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<ApplicationUser> GetById(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }
        public async Task<ApplicationUser> GetByUserName(string userName)
        {
            return await _userManager.FindByNameAsync(userName);
        }
        public async Task<string> GetFullName(string userId)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == userId);
            return user != null ? user.FirstName + " " + user.LastName : "";
        }
        public async Task<string> GetPhoneNumber(ApplicationUser user)
        {
            return await _userManager.GetUserNameAsync(user);
        }
        public async Task<ApplicationUser> GetUser(ClaimsPrincipal userClaimsPrincipal)
        {
            return await _userManager.GetUserAsync(userClaimsPrincipal);
        }
        public async Task RefreshSignIn(ApplicationUser user)
        {
            await _signInManager.RefreshSignInAsync(user);
        }


        public async Task<List<ApplicationUser>> GetByIds(string ids, string customerType)
        {
            var users = new List<ApplicationUser>();
            try
            {
                var idVals = ids.Split(',');

                if (!string.IsNullOrEmpty(customerType))
                    users = await _userManager.Users.Where(x => idVals.Contains(x.Id) && x.CustomerType == customerType).ToListAsync();
                else
                    users = await _userManager.Users.Where(x => idVals.Contains(x.Id)).ToListAsync();
                return users;
            }
            catch (Exception e)
            {
                return users;
            }
        }

        public async Task<bool> IsUserNameUnique(string userName)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.UserName != userName);
        }
        public async Task<bool> IsEconomicCodeUnique(string EconomicCode)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.EconomicCode != EconomicCode);
        }
        public async Task<bool> IsNationalCodeUnique(string NationalCode)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.NationalCode != NationalCode);
        }
        public async Task<bool> IsEmailUnique(string Email)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.Email != Email);
        }
        public async Task<bool> IsEconomicCodeUnique(string userId, string EconomicCode)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.EconomicCode != EconomicCode && x.Id != userId);
        }
        public async Task<bool> IsNationalCodeUnique(string userId, string NationalCode)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.NationalCode != NationalCode && x.Id != userId);
        }
        public async Task<bool> IsEmailUnique(string userId, string Email)
        {
            return await _Context.AspNetUsers.AnyAsync(x => x.Email != Email && x.Id != userId);
        }

    }
}
