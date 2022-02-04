using DAL.Models;
using Repository.Class;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IAspNetUserClaimsRepository
    {
        Task<bool> HaveAccess(string userId);
        Task<List<AspNetUserClaim>> GetByUserId(string userId);
        Task<GeneralResponse> RemoveRenge(List<AspNetUserClaim> aspNetUserClaims);
    }
}
