using System.ComponentModel.DataAnnotations;

namespace RiserAPI.Models.Jump
{
    public class MalfunctionType : Base
    {
        [Display(Name = "Malfunction Type")]
        public int Name { get; set; }
        //
        public Malfunction Malfunction { get; set; }
    }
}