using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Jump;

namespace RiserAPI.Models.Link.Jump
{
    public class JumpMalfunction
    {
        public int JumpId { get; set; }
        public Models.Jump.Jump Jump { get; set; }
        //
        public int MalfunctionId { get; set; }
        public Malfunction Malfunction { get; set; }
    }
    
    public class JumpMalfunctionConfiguration : IEntityTypeConfiguration<JumpMalfunction>
    {
        public void Configure(EntityTypeBuilder<JumpMalfunction> builder)
        {
            builder.HasKey(k => new
            {
                k.JumpId,
                k.MalfunctionId
            });

            builder.HasOne(o => o.Jump)
                .WithMany(m => m.JumpMalfunctions)
                .HasForeignKey(fk => fk.JumpId).OnDelete(DeleteBehavior.NoAction);
            //
            builder.HasOne(o => o.Malfunction)
                .WithMany(m => m.JumpMalfunctions)
                .HasForeignKey(fk => fk.MalfunctionId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}