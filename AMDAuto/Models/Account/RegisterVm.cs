using AMDAuto.Services.User;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class RegisterVm : IValidatableObject
    {
        [Required(ErrorMessage = "Numele este obligatoriu!")]
        [MaxLength(100, ErrorMessage = "Numele nu trebuie sa depaseasca 100 de caractere! ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email-ul este obligatoriu!")]
        [EmailAddress(ErrorMessage = "Email invalid!")]
        [MaxLength(100, ErrorMessage = "Email prea lung!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola este obligatorie!")]
        [MaxLength(20, ErrorMessage = "Parola prea lunga!")]
        [MinLength(8, ErrorMessage = "Parola trebuie sa aiba minim 8 caractere!")]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            var service = validationContext.GetService(typeof(UserAccountService)) as UserAccountService;
            var emailExists = service.EmailExists(Email);

            if (emailExists)
            {
                result.Add(new ValidationResult("Email-ul exista deja!", new List<string> { nameof(Email) }));
            }
            return result;
        }
    }
}
