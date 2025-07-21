using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

[Table("tbl_users")]
public class User : BaseEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
}
