using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class ModelVm
    {
        public ModelVm()
        {
            Makes = new List<SelectListItem>();
        }

       
        public int Id { get; set; }
        [Required(ErrorMessage = "Introduceti modelul autovehiculului!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Selectati marca autovehiculului!")]
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        
        public List<SelectListItem> Makes { get; set; }
    }
}
