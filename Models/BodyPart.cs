namespace MotionFlow.Models
{
    public class BodyPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ExerciseVsBodyPart> ExerciseVsBodyParts { get; set; } = new List<ExerciseVsBodyPart>();
    }
}
