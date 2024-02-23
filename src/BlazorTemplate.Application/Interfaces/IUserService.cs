using System.Security.Claims;
using Blazor.Domain.Common;
using Blazor.Infrastructure.Identity;

namespace Blazor.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<ServiceResult> CreateUser(
            string userName,
            string email,
            string password,
            string firstName,
            string lastName);

        Task<ServiceResult> DeleteUser(string userId);

        Task<ServiceResult> AssignRoles(
            string userId,
            IEnumerable<string> newRoles);

        Task<IEnumerable<string>> GetUserRoles(string userId);

        Task<IEnumerable<string>> GetAllRoles();

        Task<ServiceResult> SetUserAccountStatus(string userId, UserAccountStatus accountStatus);
    }
}