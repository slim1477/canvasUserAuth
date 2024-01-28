namespace MemberVerify.Models
{
    public class Answer
    {
        public string Question { get; set; } = string.Empty;
        public List<string> QuestionAnswer = new();
    }
}
