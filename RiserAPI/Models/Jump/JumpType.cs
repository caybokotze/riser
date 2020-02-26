using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class JumpType : Base
    {
        [StringLength(25)]
        public string Name { get; set; }
        //Jump already configured from jump.
        public Jump Jump { get; set; }
    }
    
    public class JumpTypeConfiguration : IEntityTypeConfiguration<JumpType>
    {
        public void Configure(EntityTypeBuilder<JumpType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
