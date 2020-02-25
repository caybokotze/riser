using System.ComponentModel.DataAnnotations;

namespace RiserAPI.Models.Jump
{
    public class JumpType : Base
    {
        [StringLength(25)]
        public string Name { get; set; }
        //Jump already configured from jump.
        public Jump Jump { get; set; }
    }
}
