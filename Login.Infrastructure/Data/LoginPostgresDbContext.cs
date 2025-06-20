using Login.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Login.Infrastructure.Data;

public class AuthDbContext : IdentityDbContext<AppUser, AppRole, Guid,
    IdentityUserClaim<Guid>, AppUserRole, IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AppUser>().ToTable("Users");
        builder.Entity<AppRole>().ToTable("Roles");
        builder.Entity<AppUserRole>().ToTable("UserRoles");

        builder.Entity<AppUserRole>(userRole =>
        {
            userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

            userRole.HasOne(ur => ur.User)
                    .WithMany(u => u.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

            userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
        });

        //Data seeding
        var userType = new List<AppRole>
        {
            new AppRole
                {
            Id = Guid.Parse("408df6a4-e4fd-41c7-aa3c-071502d1f1a4"),
            Name = "Free",
            NormalizedName = "FREE",
            RoleName = "Free",
            CreatedAt = DateTime.UtcNow,
        },
            new AppRole
        {
            Id = Guid.Parse("408df6a4-e4fd-41c7-aa3c-071502D1f2a5"),
            Name = "Paid",
            NormalizedName = "PAID",
            RoleName = "Paid",
            CreatedAt = DateTime.UtcNow,
        }
        };
    
    }
}

