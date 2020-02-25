using System.ComponentModel.DataAnnotations;

namespace RiserAPI.Models.Jump
{
    public class SkydiveType : Base
    {
        [Display(Name = "Skydive Type")]
        public string Name { get; set; }
        //Skydive
        public Skydive Skydive { get; set; }
    }
}