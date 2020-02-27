using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.User
{
    public class LicenseType : Base
    {
        [Display(Name = "License Name")]
        public string Name { get; set; }
    }
    public class LicenseTypeConfiguration : IEntityTypeConfiguration<LicenseType>
    {
        public void Configure(EntityTypeBuilder<LicenseType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}