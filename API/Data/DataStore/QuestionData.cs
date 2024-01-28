
using System;
using System.Collections.Generic;
using MemberVerify.Models;
using MemberVerify.Enums;


namespace MemberVerify.Data.DataStore
{
    public static class QuestionData
    {
        public static List<Question> questions = new List<Question>()
    {
      new ()
      {
        Id = 1,
        QuestionText = "What type of accounts do you have with us?",
        Answer = new(),
        QuestionType = QuestionType.Primary,
        QualifyQuestionId = 2,

      },
      new ()
      {
        Id = 2,
        QuestionText = "What was the last transaction (or recent, must be within 2 weeks) that went through your account?",
        Answer = new(),
        QuestionType = QuestionType.Primary

      },
      new ()
      {
        Id = 3,
        QuestionText = "Do you receive any direct deposits to your account?",
        Answer = new(),
        QuestionType = QuestionType.Primary

      },
      new ()
      {
        Id = 4,
        QuestionText = "What is the location of your home branch?",
        Answer = new(),
        QuestionType = QuestionType.Secondary

      },
      new ()
      {
        Id = 5,
        QuestionText = "Is there a joint signor on any of your accounts?",
        Answer = new(),
        QuestionType = QuestionType.Secondary
      },
      new ()
      {
        Id = 6,
        QuestionText = "What is the balance on any of your accounts?",
        Answer = new(),
        QuestionType = QuestionType.FollowUp
      },
      new ()
      {
        Id = 7,
        QuestionText = "What is the balance on any of your accounts?",
        Answer = new(),
        QuestionType = QuestionType.FollowUp
      }
    };
    }
}
