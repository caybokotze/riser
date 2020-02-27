using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Link.User
{
    public class UserGear
    {
        //User
        public int UserId { get; set; }
        public Models.User.User User { get; set; }
        //Gear Item.
        public int GearItemId { get; set; }
        public GearItem GearItem { get; set; }
        //
        public DateTime DateAdded { get; set; }
    }
    
    public class UserGearConfiguration : IEntityTypeConfiguration<UserGear>
    {
        public void Configure(EntityTypeBuilder<UserGear> builder)
        {
            builder.HasKey(k => new
            {
                k.UserId,
                k.GearItemId
            });
            //
            builder.HasOne(o => o.User)
                .WithMany(m => m.UserGearItems)
                .HasForeignKey(fk => fk.UserId).OnDelete(DeleteBehavior.NoAction);
            //
            builder.HasOne(o => o.GearItem)
                .WithMany(m => m.UserGearItems)
                .HasForeignKey(fk => fk.GearItemId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}