using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace VirtaApi.Models
{
    public class Role : IdentityRole
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}