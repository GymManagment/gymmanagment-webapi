using GymManagment.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace GymManagment.Domain.Entities.Admins;

public class Admin:Auditable
{
    [Required]
    public long UserId { get; set; }
    
    [Required]
    public long ProductId { get; set; }

    [Required]
    public long ChatId { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly Birthdate { get; set; }
    public Gander isMale { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;
    public bool EmailConfirmed { get; set; }
    public string role { get; set; } = string.Empty;
}
