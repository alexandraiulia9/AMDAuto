using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage = "Email-ul este obligatoriu!")]
        [EmailAddress(ErrorMessage = "Email invalid!")]
        [MaxLength(100, ErrorMessage = "Email prea lung!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Parola este obligatorie!")]
        [MaxLength(20, ErrorMessage = "Parola prea lunga!")]
        [MinLength(8, ErrorMessage = "Parola trebuie sa aiba minim 8 caractere!")]
        public string Password { get; set; }
        public bool CredentialsInvalid { get; set; }
    }
}
