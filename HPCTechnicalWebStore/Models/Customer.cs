using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace HPCTechnicalWebStore.Models;

public class Customer
{
    public int Id { get; set; }
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First name is required")]
    [StringLength(50)]
    [MinLength(3, ErrorMessage = "First name must be at least 3 characters long")]
    public string FirstName { get; set; } = null!;
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
    [Display(Name = "Phone Number")]
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    public string? Phone { get; set; }
    [Display(Name = "Home Address")]
    public string? Address { get; set; }
    [Display(Name = "Email Address")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
