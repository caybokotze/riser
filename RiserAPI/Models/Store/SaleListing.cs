using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RiserAPI.Models.Link.Store;

namespace RiserAPI.Models.Store
{
    public class SaleListing : Base
    {
        [Range(0, 100_000)]
        [Display(Name = "Selling Price")]
        [Required(ErrorMessage = "A selling price is required.")]
        public float SellingPrice { get; set; }
        
        [StringLength(500, ErrorMessage = "You are limited to 500 characters.")]
        [Required(ErrorMessage = "Please enter a short description.")]
        public string Description { get; set; }
        
        public bool Active { get; set; }

        public IEnumerable<ListedGearItem> ListedGearItems { get; set; }
        public IEnumerable<GearSaleImage> GearSaleImages { get; set; }
    }
}