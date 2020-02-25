using System.ComponentModel.DataAnnotations;

namespace RiserAPI.Models.Jump
{
    public class JumpType : Base
    {
        [StringLength(25)]
        public string Name { get; set; }
        //user
        public Jump Jump { get; set; }
    }
}
