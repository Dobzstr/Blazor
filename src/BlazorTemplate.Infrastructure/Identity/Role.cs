using Microsoft.AspNetCore.Identity;

namespace Blazor.Infrastructure.Identity
{
    public class Role : IdentityRole
    {
        public Role() : base()
        { }

        public Role(string roleName) : base(roleName)
        { }

        public virtual ICollection<UserRole> UserRoles { get; set; } = null!;
    }
}
