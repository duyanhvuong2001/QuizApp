using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels
{
    public class QuestionUpdateVM
    {
        public string Content { get; set; }
        public Guid Id { get; set; }
        public Guid? CorrectAnswerId { get; set; }
    }
}
