using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Class;
using Repository.Context;
using Repository.Interface;

namespace Repository.Repositories
{
    public class AspNetUserClaimsRepository : GeneralRepository<AspNetUserClaim>, IAspNetUserClaimsRepository
    {
        public AspNetUserClaimsRepository(DataBaseContext Context) : base(Context) { }

        public async Task<List<AspNetUserClaim>> GetByUserId(string userId)
        {
            return await _Context.AspNetUserClaims.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<bool> HaveAccess(string userId)
        {
            return await _Context.AspNetUserClaims.AnyAsync(x => x.UserId == userId);
        }

        public async Task<GeneralResponse> RemoveRenge(List<AspNetUserClaim> aspNetUserClaims)
        {
            var res = new GeneralResponse();
            try
            {
                _Context.AspNetUserClaims.RemoveRange(aspNetUserClaims);
                await Save();
                res.IsSuccess = true;
                res.Message = Message.SubmitSuccessDelete;
                return res;
            }
            catch (Exception ex)
            {
                res.Message = Message.SubmitErrorDelete;
                res.ErrorMessage = ex.Message;
                return res;
            }
        }
    }
}
