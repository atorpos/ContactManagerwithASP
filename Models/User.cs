using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace ContactManager.Models
{
    public class User
    {

        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public int? tel { get; set; }

        [Required(ErrorMessage = "Please enter the email")]
        public string? email { get; set; }

        [Required(ErrorMessage = "Please enther the type")]
        public string? cat_type { get; set; }

    }
}

