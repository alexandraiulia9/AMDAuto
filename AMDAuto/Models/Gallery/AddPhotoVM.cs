using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class AddPhotoVM : IValidatableObject
    {
        [Required]
        public IFormFile Photo { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();

            if (Photo != null)
                if (Photo.ContentType.ToLower() != "image/jpeg"
                        && Photo.ContentType.ToLower() != "image/jpg"
                        && Photo.ContentType.ToLower() != "image/png")
                {
                    result.Add(new ValidationResult("Invalid file format!", new List<string> { nameof(Photo) }));
                }

            return result;
        }
    }
}
