using System.Security.Claims;

namespace Blazor.Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ClaimsPrincipal?> GetUser();
    }
}