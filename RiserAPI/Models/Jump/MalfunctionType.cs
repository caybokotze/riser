using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class MalfunctionType : Base
    {
        [Display(Name = "Malfunction Type")]
        public int Name { get; set; }
        //Malfunction already configured from malfunction.
        public Malfunction Malfunction { get; set; }
    }
    
    public class MalfunctionTypeConfiguration : IEntityTypeConfiguration<MalfunctionType>
    {
        public void Configure(EntityTypeBuilder<MalfunctionType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}