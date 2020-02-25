using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RiserAPI.Models.Jump;
using RiserAPI.Models.Link.Gear;
using RiserAPI.Models.Link.Jump;

namespace RiserAPI.Models.Gear
{
    public class Rig
    {
        [Display(Name = "Rig Name")]
        public string Name { get; set; }
        //Base Jump
        public IEnumerable<BaseJump> BaseJumps { get; set; }
        //Skydive
        public IEnumerable<Skydive> Skydives { get; set; }

        public IEnumerable<RigCollection> RigCollections { get; set; }
        public IEnumerable<JumpGearItem> JumpGearItems { get; set; }
    }
}