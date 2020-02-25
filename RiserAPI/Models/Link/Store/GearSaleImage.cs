using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;
using RiserAPI.Models.Store;

namespace RiserAPI.Models.Link.Store
{
    public class GearSaleImage
    {
        //Image navigational property.
        public Image Image { get; set; }
        public int ImageId { get; set; }
        //Sale listing.
        public SaleListing SaleListing { get; set; }
        public int SaleListingId { get; set; }
        //Gear item.
        public GearItem GearItem { get; set; }
        public int GearItemId { get; set; }
    }
    
    public class GearSaleImageConfiguration : IEntityTypeConfiguration<GearSaleImage>
    {
        public void Configure(EntityTypeBuilder<GearSaleImage> builder)
        {
            builder.HasKey(k => new
            {
                k.ImageId,
                k.SaleListingId,
                k.GearItemId
            });
            //Gear Sale Image has one Image.
            builder.HasOne(o => o.Image)
                .WithMany(m => m.GearSaleImages)
                .HasForeignKey(fk => fk.ImageId);
            //Gear sale image has one gear item.
            builder.HasOne(o => o.GearItem)
                .WithMany(m => m.GearSaleImages)
                .HasForeignKey(fk => fk.GearItemId);
            //Gear sale image has one sale listing.
            builder.HasOne(o => o.SaleListing)
                .WithMany(m => m.GearSaleImages)
                .HasForeignKey(fk => fk.SaleListingId);

        }
    }
}