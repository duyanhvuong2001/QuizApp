namespace QuizApp.Models.Domain
{
    public class Attempt
    {
        public Guid Id { get; set; }
        public ICollection<UserResponse> Responses { get; set; }

    }
}
