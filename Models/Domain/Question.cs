using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Models.Domain
{
    public class Question
    {
        public Guid Id { get; set; }

        public Guid QuizId { get; set; }

        [ForeignKey("QuizId")]
        public Quiz Quiz { get; set; }
        public string Content { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Guid? CorrectAnswerId { get; set; }
    }
}
