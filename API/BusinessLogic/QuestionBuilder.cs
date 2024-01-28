using MemberVerify.BusinessLogic.Util;
using MemberVerify.Models;

namespace MemberVerify.BusinessLogic
{
    /// <summary>
    /// constructs the verification questions
    /// </summary>
    public  class QuestionBuilder
    {
        private readonly int _id;
        public QuestionBuilder(int id) { _id = id; }
        public  Answer GetOpeningQuestionAndAnswer()
        {
            Answer Qa = new()
            {
                Question = QuestionGetter.GetOpeningQuestion(),
                QuestionAnswer = VerificationAnswer.AnswerToOpeningQuestion(_id)
            };
            return Qa;
        }

        public string BuildQuestions()
        {
            string res = string.Empty;
            List<string> curAnswer = GetOpeningQuestionAndAnswer().QuestionAnswer;
            //if(curAnswer.)
            foreach(string answer in curAnswer)
            {
                switch (answer.ToLower())
                {
                    case "savings":
                            res =  "I have a saving account";
                        break;
                    case "checking":
                        res = "I have a checking account";
                        break;
                    case "lending":
                        res = "I have a lending account";
                        break;




                }
            }
            return res;
        }
    }
}
