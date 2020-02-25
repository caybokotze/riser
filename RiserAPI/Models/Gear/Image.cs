using System.Collections.Generic;
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
        public IEnumerable<UserImage> UserImages { get; set; }
        #endregion
    }
}