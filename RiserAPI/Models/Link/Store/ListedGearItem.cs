using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;
using RiserAPI.Models.Store;

namespace RiserAPI.Models.Link.Store
{
    public class ListedGearItem
    {
        //Note: Gear Item
        public GearItem GearItem { get; set; }
        public int GearItemId { get; set; }
        //Note: Sale Listing
        public SaleListing SaleListing { get; set; }
        public int SaleListingId { get; set; }
    }
    
    public class ListedGearConfiguration : IEntityTypeConfiguration<ListedGearItem>
    {
        public void Configure(EntityTypeBuilder<ListedGearItem> builder)
        {
            builder.HasKey(k => new
            {
                k.GearItemId,
                k.SaleListingId
            });
            
            //Listed Gear has one Gear Item.
            builder.HasOne(o => o.GearItem)
                .WithMany(m => m.ListedGearItems)
                .HasForeignKey(fk => fk.GearItemId);
            //Listed Gear has One sale listing.
            builder.HasOne(o => o.SaleListing)
                .WithMany(m => m.ListedGearItems)
                .HasForeignKey(fk => fk.SaleListingId);
        }
    }
}