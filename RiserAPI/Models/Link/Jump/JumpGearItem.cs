using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Link.Jump
{
    public class JumpGearItem
    {
        //Jump
        public int JumpId { get; set; }
        public Models.Jump.Jump Jump { get; set; }
        //Gear
        public int GearItemId { get; set; }
        public GearItem GearItem { get; set; }
        //Rig
        public int RigId { get; set; }
        public Rig Rig { get; set; }
    }
    
    public class JumpGearConfiguration : IEntityTypeConfiguration<JumpGearItem>
    {
        public void Configure(EntityTypeBuilder<JumpGearItem> builder)
        {
            builder.HasKey(k => new
            {
                k.GearItemId, 
                k.JumpId,
                k.RigId
            });
            
            //Note: ump has many jump gear items.
            builder.HasOne(o => o.Jump)
                .WithMany(m => m.JumpGearItems)
                .HasForeignKey(fk => fk.JumpId).OnDelete(DeleteBehavior.NoAction);
            //Note: Gear item has many jump gear items.
            builder.HasOne(o => o.GearItem)
                .WithMany(m => m.JumpGearItems)
                .HasForeignKey(fk => fk.GearItemId).OnDelete(DeleteBehavior.NoAction);
            //Note: Rig has many jump gear items.
            builder.HasOne(h => h.Rig)
                .WithMany(m => m.JumpGearItems)
                .HasForeignKey(fk => fk.RigId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
