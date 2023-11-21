namespace MotionFlow.Models
{
    public class Physio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSuperAdmin { get; set; }
        public List<ExerciseVsPhysio> ExerciseVsPhysios { get; set; } = new List<ExerciseVsPhysio>();
     
    }
}
