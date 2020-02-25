using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Link.Jump
{
    public class JumpImage
    {
        //Image
        public int ImageId { get; set; }
        public Image Image { get; set; }
        //Jump
        public int JumpId { get; set; }
        public Models.Jump.Jump Jump { get; set; }
    }
    
    public class JumpImageConfiguration : IEntityTypeConfiguration<JumpImage>
    {
        public void Configure(EntityTypeBuilder<JumpImage> builder)
        {
            builder.HasKey(k => new
            {
                k.ImageId,
                k.JumpId
            });

            builder.HasOne(o => o.Image)
                .WithMany(m => m.JumpImages)
                .HasForeignKey(fk => fk.ImageId);

            builder.HasOne(o => o.Jump)
                .WithMany(m => m.JumpImages)
                .HasForeignKey(fk => fk.JumpId);
        }
    }
}