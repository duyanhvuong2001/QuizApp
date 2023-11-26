namespace QuizApp.Models.Domain
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Question> Questions { get; set; }

        public Quiz()
        {
            Questions = new List<Question>();
        }
    }
}
