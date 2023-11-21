namespace MotionFlow.Models
{
    public class ExerciseVsPhysio
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int PhysioId { get; set; }
        public Physio Physio { get; set; }
    }
}
