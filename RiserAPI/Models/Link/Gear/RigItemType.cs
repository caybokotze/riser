using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Link.Gear
{
    public class RigItemType
    {
        
    }
    
    public class RigItemTypeConfiguration : IEntityTypeConfiguration<RigItemType>
    {
        public void Configure(EntityTypeBuilder<RigItemType> builder)
        {
            builder.HasKey(k => new
            {
                
            });
            
        }
    }
}