using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Link.Gear;

namespace RiserAPI.Models.Gear
{
    public class RigCollectionType : Base
    {
        public string Name { get; set; }
        //Note: Rig collection type already configured from rig collection.
        public RigCollection RigCollection { get; set; }
    }
    
    public class RigCollectionTypeConfiguration : IEntityTypeConfiguration<RigCollectionType>
    {
        public void Configure(EntityTypeBuilder<RigCollectionType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}