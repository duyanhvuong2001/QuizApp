using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels
{
    public class QuestionDisplayVM
    {
        public string Content { get; set; }
        public Guid Id { get; set; }
        public List<AnswerVM> Answers { get; set; }
    }
}
