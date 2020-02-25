using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Link.Gear;
using RiserAPI.Models.Link.Jump;
using RiserAPI.Models.Link.Store;
using RiserAPI.Models.User;

namespace RiserAPI.Models.Gear
{
    public class GearItem : Base
    {
        
        [Required]
        public string Name { get; set; }
        
        public string SerialNumber { get; set; }
        [Required]
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        
        #region Navigational Properties
        public IEnumerable<ListedGearItem> ListedGearItems { get; set; }
        public IEnumerable<RigCollection> RigCollections { get; set; }
        public IEnumerable<JumpGearItem> JumpGearItems { get; set; }
        public IEnumerable<GearImage> GearImages { get; set; }
        public IEnumerable<GearSaleImage> GearSaleImages { get; set; }
        
        [ForeignKey("GearType")]
        public int GearTypeId { get; set; }
        public GearType GearType { get; set; }
        
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User.User User { get; set; }
        //
        #endregion
    }
    
    public class GearItemConfiguration : IEntityTypeConfiguration<GearItem>
    {
        public void Configure(EntityTypeBuilder<GearItem> builder)
        {
            builder.HasKey(h => h.Id);
            //Note: Gear item has one gear type.
            builder.HasOne(o => o.GearType)
                .WithOne(o => o.GearItem)
                .HasForeignKey<GearItem>(fk => fk.GearTypeId);
            //Note: Gear item has one user.
            builder.HasOne(o => o.User)
                .WithMany(m => m.GearItems)
                .HasForeignKey(fk => fk.UserId);
        }
    }
}
