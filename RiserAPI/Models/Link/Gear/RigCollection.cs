using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Link.Gear
{
    public class RigCollection
    {
        //Rig
        public int RigId { get; set; }
        public Rig Rig { get; set; }
        //Rig Item Type
        public int RigCollectionTypeId { get; set; }
        public RigCollectionType RigCollectionType { get; set; }
        //Gear
        public int GearItemId { get; set; }
        public GearItem GearItem { get; set; }
    }
    
    public class RigCollectionConfiguration : IEntityTypeConfiguration<RigCollection>
    {
        public void Configure(EntityTypeBuilder<RigCollection> builder)
        {
            builder.HasKey(k => new
            {
                k.GearItemId,
                k.RigId,
                k.RigCollectionTypeId
            });
            //Note: Rig Collection has one Rig
            builder.HasOne(o => o.Rig)
                .WithMany(m => m.RigCollections)
                .HasForeignKey(fk => fk.RigId);
            
            //Note: Rig Collection has one RigCollectionType.

            builder.HasOne(o => o.RigCollectionType)
                .WithOne(m => m.RigCollection)
                .HasForeignKey<RigCollection>(fk => fk.RigCollectionTypeId);
            
            //Note: Rig Collection has one Rig

            builder.HasOne(o => o.GearItem)
                .WithMany(m => m.RigCollections)
                .HasForeignKey(fk => fk.GearItemId);
        }
    }
}