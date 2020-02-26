using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Gear
{
    public class GearType : Base
    {
        public string Name { get; set; }
        //Note: One gear item.
        //Note: Configuration already done from gear item side.
        public GearItem GearItem { get; set; }
    }
    
    public class GearTypeConfiguration : IEntityTypeConfiguration<GearType>
    {
        public void Configure(EntityTypeBuilder<GearType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}