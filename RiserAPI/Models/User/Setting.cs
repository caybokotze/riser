using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Enum;

namespace RiserAPI.Models.User
{
    public class Setting : Base
    {
        public Unit Unit { get; set; }

        #region
        public User User { get; set; }
        #endregion
    }
    
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
