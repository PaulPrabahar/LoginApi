using Login.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(30)]
    public required string UserName { get; set; }

    [Required]
    [MaxLength(50)]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MaxLength(20)]
    public required string Password { get; set; }

    [Required]
    [Range(1000000000, 9999999999)]
    public required long MobileNumber { get; set; }
    public UserTypeEnum UserType { get; set; } = UserTypeEnum.Free;
}
