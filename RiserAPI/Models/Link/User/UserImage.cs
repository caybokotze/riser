using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Gear;

namespace RiserAPI.Models.Link.User
{
    public class UserImage
    {
        //User
        public int UserId { get; set; }
        public Models.User.User User { get; set; }
        //Image
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
    
    public class UserImageConfiguration : IEntityTypeConfiguration<UserImage>
    {
        public void Configure(EntityTypeBuilder<UserImage> builder)
        {
            builder.HasKey(k => new
            {
                k.ImageId,
                k.UserId
            });
        }
    }
}