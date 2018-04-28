using System.ComponentModel.DataAnnotations;

namespace login_and_registration.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength (2)]
        [Display(Name = "First Name")]
        public string First_name { get; set; }
        [Required]
        [MinLength (2)]
        [Display(Name = "Last Name")]
        public string Last_name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [MinLength (8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Compare ("Password")]
        [Display(Name = "Confirm Password")]
        public string Confirm_password { get; set; }
    }
}