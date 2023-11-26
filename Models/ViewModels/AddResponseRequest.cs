using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels
{
    public class AddResponseRequest
    {
        public Guid QuestionId { get; set; }
        public Guid AnswerId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
