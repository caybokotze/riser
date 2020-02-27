using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Link.Gear;
using RiserAPI.Models.Link.Jump;
using RiserAPI.Models.Link.Store;
using RiserAPI.Models.Link.User;

namespace RiserAPI.Models.Gear
{
    public class Image : Base
    {
        public string Directory { get; set; }
        public string Guid { get; set; }

        #region Navigational Properties

        public IEnumerable<GearImage> GearImages { get; set; }
        public IEnumerable<GearSaleImage> GearSaleImages { get; set; }
        public IEnumerable<JumpImage> JumpImages { get; set; }
        [NotMapped]
        public IEnumerable<UserImage> UserImages { get; set; }
        #endregion
    }
    
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}