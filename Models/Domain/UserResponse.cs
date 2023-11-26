using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models.Domain
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        
        public Guid AnswerId { get; set; }

        [ForeignKey("AnswerId")]
        public Answer Answer { get; set; }

        public bool IsCorrect { get; set; }
        public DateTime Timestamp { get; set; }
        public Attempt Attempt { get; set; }
    }
}
