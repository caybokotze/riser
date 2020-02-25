using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class Aircraft : Base
    {
        [Display(Name="Name")]
        [StringLength(30)]
        public string Name { get; set; }

        [Display(Name="Max Speed")]
        [Required(ErrorMessage = "Max speed is required.")]
        public float MaxSpeed { get; set; }
        
        [Required(ErrorMessage = "Max People is required.")]
        [Display(Name="Max Allowed People")]
        public int MaxPeople { get; set; }

        [Display(Name="Max Altitude")]
        [Required(ErrorMessage = "Max Altitude is required.")]
        public float MaxAltitude { get; set; }
        
        //Skydives
        public IEnumerable<Skydive> Skydives { get; set; }
    }
    
    public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
