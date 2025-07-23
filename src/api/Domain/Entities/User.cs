using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities;

[Table("tbl_users")]
public class User : BaseEntity
{
    [Column("name")]
    public required string Name { get; set; }
    [Column("email")]
    public required string Email { get; set; }
    [Column("password_hash")]
    public required string PasswordHash { get; set; }
}
