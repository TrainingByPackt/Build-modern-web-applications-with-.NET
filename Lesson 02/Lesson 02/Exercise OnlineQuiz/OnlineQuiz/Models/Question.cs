namespace OnlineQuiz.Models
{
    public class Question
    {
        public int Id { get; set; }
        public QuestionCategory Category { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
    }
}