namespace RiserAPI.Models.Jump
{
    //route-get: skydive/disciplines
    //route-get/{id}: skydive/discipline/{id}
    //route-post: skydive/discipline
    public class SkydiveDiscipline : Base
    {
        public string Name { get; set; }

        public Skydive Skydive { get; set; }
    }
}
