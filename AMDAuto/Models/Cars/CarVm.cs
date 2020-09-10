using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class CarVm 
    {
        public CarVm()
        {
            Makes = new List<SelectListItem>();
            Models = new List<SelectListItem>();
        }
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }

        [Required(ErrorMessage = "Selectati marca autovehiculului sau introduceti una noua!")]
        public int MakeNameId { get; set; }
       
        [Required(ErrorMessage = "Selectati modelul autovehiculului!")]
        public int ModelId { get; set; }

        public List<SelectListItem> Makes { get; set; }
        public List<SelectListItem> Models { get; set; }

        [Required(ErrorMessage = "Completati numarul de inmatriculare!")]
        [MaxLength(8, ErrorMessage = "Numar de inmatriculare eronat!")]
        public string LicenseNumber { get; set; }
        [Required(ErrorMessage = "Completati anul de fabricatie al masinii!")]
        public int ReleaseYear { get; set; }
       
       
    }
}
