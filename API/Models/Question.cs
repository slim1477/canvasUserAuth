using MemberVerify.Enums;


namespace MemberVerify.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Answer { get; set; } = new();
        public QuestionType QuestionType { get; set; }
        public int QualifyQuestionId { get; set; }
        public string QuestionCategory { get; set; } = string.Empty;
    }
}