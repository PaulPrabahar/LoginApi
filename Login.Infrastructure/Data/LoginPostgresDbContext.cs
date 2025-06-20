using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Domain.Entities;

namespace Login.Infrastructure.Data;

public class LoginPostgresDbContext:DbContext
{
    public LoginPostgresDbContext(DbContextOptions<LoginPostgresDbContext> dbContextOptions):base(dbContextOptions)
    {
        
    }
    public DbSet<User> Users { get; set; }
}
