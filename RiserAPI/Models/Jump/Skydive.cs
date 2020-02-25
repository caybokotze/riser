using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;
using RiserAPI.Models.Link.Jump;

namespace RiserAPI.Models.Jump
{
    public class Skydive : Base
    {
        [Required(ErrorMessage = "Exit Altitude is required.")]
        [Display(Name="Exit Altitude")]
        [Range(0, 30_000)]
        public float ExitAltitude { get; set; }
        
        [Required(ErrorMessage = "Deployment Altitude is required.")]
        [Display(Name = "Deployment Altitude")]
        [Range(0, 30_000)]
        public float DeploymentAltitude { get; set; }
        
        [Display(Name = "Free Fall Time")]
        [Range(0, 600)]
        public float FreefallTime { get; set; }
        
        [Display(Name = "Free Fall Maximum Speed")]
        [Range(0, 1000)]
        public float FreefallMaxspeed { get; set; }
        
        [Range(0, 1000)]
        public float AverageSpeed { get; set; }
        
        #region navigational properties.
        //Skydive Discipline
        public int DisciplineId { get; set; }
        public SkydiveDiscipline SkydiveDiscipline { get; set; }
        //Skydiving Type
        public int SkydiveTypeId { get; set; }
        public SkydiveType SkydiveType { get; set; }
        //Aircraft
        public int AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }
        //Jump
        public int JumpId { get; set; }
        public Jump Jump { get; set; }
        //Rig
        public int RigId { get; set; }
        public Rig Rig { get; set; }

        #endregion
        
    }
    
    public class SkydiveConfiguration : IEntityTypeConfiguration<Skydive>
    {
        public void Configure(EntityTypeBuilder<Skydive> builder)
        {
            builder.HasKey(k => k.Id);
            //Note: One Skydive could one rig.
            builder.HasOne(h => h.Rig)
                .WithMany(m => m.Skydives)
                .HasForeignKey(fk => fk.RigId);
            //Note: One skydive can have one aircraft.
            builder.HasOne(h => h.Aircraft)
                .WithMany(m => m.Skydives)
                .HasForeignKey(f => f.AircraftId);
            //Note: One skydive can have one SkydiveType.
            builder.HasOne(h => h.SkydiveType)
                .WithOne(o => o.Skydive)
                .HasForeignKey<Skydive>(fk => fk.SkydiveTypeId);
            //Note: One skydive can have one Discipline.
            builder.HasOne(h => h.SkydiveDiscipline)
                .WithOne(o => o.Skydive)
                .HasForeignKey<Skydive>(fk => fk.DisciplineId);
        }
    }
}
