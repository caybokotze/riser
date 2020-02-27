using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Link.Gear
{
    public class GearImage
    {
        public int ImageId { get; set; }
        public Image Image { get; set; }
        //
        public int GearItemId { get; set; }
        public GearItem GearItem { get; set; }
    }
    
    public class GearImageConfiguration : IEntityTypeConfiguration<GearImage>
    {
        public void Configure(EntityTypeBuilder<GearImage> builder)
        {
            builder.HasKey(k => new
            {
                k.GearItemId,
                k.ImageId
            });
            
            //One image could belong to many gear items.
            builder.HasOne(o => o.Image)
                .WithMany(m => m.GearImages)
                .HasForeignKey(fk => fk.ImageId).OnDelete(DeleteBehavior.NoAction);
            
            //One gear item could hae many gear images.

            builder.HasOne(o => o.GearItem)
                .WithMany(m => m.GearImages)
                .HasForeignKey(fk => fk.GearItemId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}