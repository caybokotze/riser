using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class SkydiveType : Base
    {
        [Display(Name = "Skydive Type")]
        public string Name { get; set; }
        //Skydive is already configured from skydive.
        public Skydive Skydive { get; set; }
    }
    
    public class SkydiveTypeConfiguration : IEntityTypeConfiguration<SkydiveType>
    {
        public void Configure(EntityTypeBuilder<SkydiveType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}