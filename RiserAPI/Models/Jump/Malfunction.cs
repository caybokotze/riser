using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Link.Jump;

namespace RiserAPI.Models.Jump
{
    public class Malfunction : Base
    {
        [Display(Name = "Malfunction name")]
        [Required]
        public string Name { get; set; }
        
        [Display]
        [Required]
        public string Comment { get; set; }
        
        //Skydive.
        public int SkydiveId { get; set; }
        public Skydive Skydive { get; set; }
        //Malfunction Type.
        public int MalfunctionTypeId { get; set; }
        public MalfunctionType MalfunctionType { get; set; }
        //
        public IEnumerable<JumpMalfunction> JumpMalfunctions { get; set; }
    }

    public class MalfunctionConfiguration : IEntityTypeConfiguration<Malfunction>
    {
        public void Configure(EntityTypeBuilder<Malfunction> builder)
        {
            builder.HasKey(k => k.Id);
            
            //Note: Malfunction has one malfunction type.
            builder.HasOne(h => h.MalfunctionType)
                .WithOne(o => o.Malfunction)
                .HasForeignKey<Malfunction>(fk => fk.MalfunctionTypeId);
        }
    }
}