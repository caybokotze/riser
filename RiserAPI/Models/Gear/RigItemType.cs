using RiserAPI.Models.Link.Gear;

namespace RiserAPI.Models.Gear
{
    public class RigCollectionType : Base
    {
        public string Name { get; set; }
        //Note: Rig collection type already configured from rig collection.
        public RigCollection RigCollection { get; set; }
    }
}