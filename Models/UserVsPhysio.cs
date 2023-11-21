namespace MotionFlow.Models
{
    public class UserVsPhysio
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PhysioId { get; set; }
        public Physio Physio { get; set; }

    }
}
