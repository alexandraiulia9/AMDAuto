using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class CarPartVm
    {
        public CarPartVm()
        {
            Operations = new List<SelectListItem>();
            Categories = new List<SelectListItem>();
        }
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campul Denumire este obligatoriu!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campul Cantitate este obligatoriu!")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Campul Operatie este obligatoriu!")]
        public Guid OperationId { get; set; }
        [Required(ErrorMessage = "Campul Categorie este obligatoriu!")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Campul Pret este obligatoriu!")]
        public float Price { get; set; }
        public List<SelectListItem> Operations { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
