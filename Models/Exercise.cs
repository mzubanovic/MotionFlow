namespace MotionFlow.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ExerciseVsBodyPart> ExerciseVsBodyParts { get; set; } = new List<ExerciseVsBodyPart>();
        public List<ExerciseVsPhysio>? ExercisesVsPhysio { get; set; } = new List<ExerciseVsPhysio>();
    }
}
