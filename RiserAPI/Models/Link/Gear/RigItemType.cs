using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Link.Gear
{
    public class RigItemType : Base
    {
        [Required]
        [Display(Name = "Rig Item type name")]
        public string Name { get; set; }
    }
    
    public class RigItemTypeConfiguration : IEntityTypeConfiguration<RigItemType>
    {
        public void Configure(EntityTypeBuilder<RigItemType> builder)
        {
            builder.HasKey(k => new
            {
                k.Id
            });
            
        }
    }
}