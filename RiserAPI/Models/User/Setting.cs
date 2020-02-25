using RiserAPI.Enum;

namespace RiserAPI.Models.User
{
    public class Setting : Base
    {
        public Setting()
        {
            
        }
        public Unit Unit { get; set; }

        #region
        public User User { get; set; }
        #endregion
    }
}
