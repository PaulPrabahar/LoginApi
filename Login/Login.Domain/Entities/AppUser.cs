using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Login.Domain.Entities;



public class AppUser : IdentityUser<Guid>
{
    public string UserName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<AppUserRole> UserRoles { get; set; }
}