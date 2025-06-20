﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Login.Domain.Entities;

public class AppUserRole : IdentityUserRole<Guid>
{
    public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

    public AppUser User { get; set; }
    public AppRole Role { get; set; }
}

