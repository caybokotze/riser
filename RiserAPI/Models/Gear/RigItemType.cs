using RiserAPI.Models.Link.Gear;

namespace RiserAPI.Models.Gear
{
    public class RigCollectionType : Base
    {
        public string Name { get; set; }

        public RigCollection RigCollection { get; set; }
    }
}