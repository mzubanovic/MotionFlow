namespace MotionFlow.Models
{
    public class ExerciseVsBodyPart
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int BodyPartId { get; set; }
        public BodyPart BodyPart { get; set; }
    }
}
