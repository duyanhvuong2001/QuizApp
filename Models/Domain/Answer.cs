namespace QuizApp.Models.Domain
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Question Question { get; set; }
        public string Content { get; set; }
    }
}
