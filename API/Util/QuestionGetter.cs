
using MemberVerify.Data.DataStore;
using MemberVerify.Enums;
using MemberVerify.Models;

namespace MemberVerify.BusinessLogic.Util
{
    /// <summary>
    /// Get questions from the question repository
    /// </summary>
    public static class QuestionGetter
    {
        /// <summary>
        /// Gets the opening question
        /// </summary>
        public static string GetOpeningQuestion()
        {
            var openingQuestion = QuestionData.questions.Where(question => question.Id == 1)
                                                        .Select(x => x.QuestionText);
           
            return  openingQuestion.First();
        }

        /// <summary>
        /// Gets all primary  questions
        /// </summary>
        public static List<Question> GetPrimaryQuestion()
        {
            return QuestionData.questions.Where(question => question.QuestionType == QuestionType.Primary && question.Id != 1).ToList();
        }
        /// <summary>
        /// Get all secondary question
        /// </summary>
        public static List<Question> GetSecondaryQuestion()
        {
            return QuestionData.questions.Where(question => question.QuestionType == QuestionType.Secondary).ToList();
        }
    }
}