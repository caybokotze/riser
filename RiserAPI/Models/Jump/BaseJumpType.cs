using System.ComponentModel.DataAnnotations;

namespace RiserAPI.Models.Jump
{
    public class BaseJumpType
    {
        [Required]
        [Display(Name = "Base Jump Type Name")]
        public string Name { get; set; }

        public BaseJump BaseJump { get; set; }
        
        //BASE Building, Antenna, Span, Earth.
    }
}