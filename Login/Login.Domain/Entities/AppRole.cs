using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Login.Domain.Entities;

public class AppRole : IdentityRole<Guid>
{
    public required string RoleName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<AppUserRole> UserRoles { get; set; }
}