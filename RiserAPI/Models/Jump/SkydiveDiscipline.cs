namespace RiserAPI.Models.Jump
{
    //route-get: skydive/disciplines
    //route-get/{id}: skydive/discipline/{id}
    //route-post: skydive/discipline
    public class SkydiveDiscipline : Base
    {
        public string Name { get; set; }
        //Skydive is already configured from skydive.
        public Skydive Skydive { get; set; }
    }
}
