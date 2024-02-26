using System.ComponentModel.DataAnnotations;
namespace Soccer.MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Messagage is required")]
        public string Message { get; set; }
    }
}

