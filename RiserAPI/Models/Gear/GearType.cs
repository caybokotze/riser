namespace RiserAPI.Models.Gear
{
    public class GearType : Base
    {
        public string Name { get; set; }
        //Note: One gear item.
        public GearItem GearItem { get; set; }
    }
}