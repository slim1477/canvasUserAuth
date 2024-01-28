namespace MemberVerify.Models.DTOs
{
    public class AnswerDTO
    {
        public string Question { get; set; } = string.Empty;
        public List<string> QuestionAnswer { get; set; } = [];
    }
}
