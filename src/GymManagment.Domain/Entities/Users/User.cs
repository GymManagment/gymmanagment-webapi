using GymManagment.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace GymManagment.Domain.Entities.Users;

public class User:Auditable
{
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly Birthdate { get; set; }
    public Gander isMale { get; set; }
    public string PhoneNumber { get; set; }= string.Empty;
    public string Image { get; set; }= string.Empty;
    public int dagree { get; set; }
    public float Payment { get; set; }

    [Required]
    public string Email { get; set; } = string.Empty;
    public bool EmailConfirmed { get; set; }
    public string Description { get; set; }=string.Empty;

    [Required]
    public string role { get; set; }=string.Empty;

}
