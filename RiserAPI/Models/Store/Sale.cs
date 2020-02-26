using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Store
{
    public class Sale : Base
    {
        public float PurchasePrice { get; set; }
        //Buyer
        public int ToUserId { get; set; }
        public User.User ToUser { get; set; }
        //Seller
        public int FromUserId { get; set; }
        public User.User FromUser { get; set; }
        //Purchase Info
        public int PurchaseInfoId { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        //Sale Listing
        public int SaleListingId { get; set; }
        public SaleListing SaleListing { get; set; }
    }
    
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(k => k.Id);
            //Builder
            builder.HasOne(o => o.ToUser)
                .WithMany(m => m.Sales)
                .HasForeignKey(fk => fk.ToUserId);
            //Seller
            builder.HasOne(o => o.FromUser)
                .WithMany(m => m.Sales)
                .HasForeignKey(fk => fk.FromUserId);
            //Purchase Info
            builder.HasOne(o => o.PurchaseInfo)
                .WithMany(m => m.Sales)
                .HasForeignKey(fk => fk.PurchaseInfoId);
            //Sale listing.
            builder.HasOne(o => o.SaleListing)
                .WithMany(m => m.Sales)
                .HasForeignKey(fk => fk.SaleListingId);
        }
    }
}