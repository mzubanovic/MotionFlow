namespace MotionFlow.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<UserVsPhysio> UsersVsPhysio { get; set; } = new List<UserVsPhysio>();
    }
}
