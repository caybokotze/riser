using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class BaseJumpType : Base
    {
        [Required]
        [Display(Name = "Base Jump Type Name")]
        public string Name { get; set; }

        //Note: Config already done from base jump side.
        public BaseJump BaseJump { get; set; }


    }
    public class BaseJumpTypeConfiguration : IEntityTypeConfiguration<BaseJumpType>
    {
        public void Configure(EntityTypeBuilder<BaseJumpType> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}