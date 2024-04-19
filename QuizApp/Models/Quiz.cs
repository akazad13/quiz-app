namespace QuizApp.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string QuizName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<QAndA> QAndAs { get; set; } = new List<QAndA>();
        public ICollection<EvaluationResult> EvaluationResults { get; set; }
    }
}
