using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Jump;
using RiserAPI.Models.Link.Gear;
using RiserAPI.Models.Link.Jump;

namespace RiserAPI.Models.Gear
{
    public class Rig : Base
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
    
    public class RigConfiguration : IEntityTypeConfiguration<Rig>
    {
        public void Configure(EntityTypeBuilder<Rig> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}