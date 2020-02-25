using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class TunnelSession : Base
    {
        [Display(Name = "Session Duration")]
        public float SessionDuration { get; set; }
        
        [Required(ErrorMessage = "Diameter is required.")]
        public float Diameter { get; set; }
        
        public float Height { get; set; }
        public int JumpId { get; set; }
        public Models.Jump.Jump Jump { get; set; }
        //
        public string TunnelName { get; set; }
    }
    
    public class TunnelSessionConfiguration : IEntityTypeConfiguration<TunnelSession>
    {
        public void Configure(EntityTypeBuilder<TunnelSession> builder)
        {
            builder.HasOne(h => h.Jump)
                .WithOne(w => w.TunnelSession)
                .HasForeignKey<TunnelSession>(fk => fk.JumpId);
        }
    }
}