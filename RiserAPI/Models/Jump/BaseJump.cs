using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Jump
{
    public class BaseJump : Base
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
        
        #region Navigational Properties.
        //Rig
        public int RigId { get; set; }
        public Rig Rig { get; set; }
        //Jump
        public int JumpId { get; set; }
        public Jump Jump { get; set; }

        public int BaseJumpTypeId { get; set; }
        public BaseJumpType BaseJumpType { get; set; }
        
        #endregion
    
    }

    public class BaseJumpConfiguration : IEntityTypeConfiguration<BaseJump>
    {
        public void Configure(EntityTypeBuilder<BaseJump> builder)
        {
            builder.HasKey(k => k.Id);
            //Note: One Base Jump can have one rig.
            builder.HasOne(h => h.Rig)
                .WithMany(m => m.BaseJumps)
                .HasForeignKey(fk => fk.RigId);
            //Note: One Base Jump has one BaseJumpType.
            builder.HasOne(h => h.BaseJumpType)
                .WithOne(o => o.BaseJump)
                .HasForeignKey<BaseJump>(fk => fk.BaseJumpTypeId);
        }
    }
}
