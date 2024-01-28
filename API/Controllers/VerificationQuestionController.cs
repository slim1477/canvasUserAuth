using Microsoft.AspNetCore.Mvc;
using MemberVerify.Models;
using MemberVerify.Data.DataStore;
using MemberVerify.BusinessLogic;
using MemberVerify.Models.DTOs;
using AutoMapper;

namespace MemberVerify.Controllers
{

    [ApiController]
    [Route("api/v1")]
    public class VerificationQuestionController (IMapper _mapper): ControllerBase
    {
        /// <summary>
        /// Gets verification question and answer for specified member Id
        /// </summary>
        /// <returns> List of member accounts</returns>
        [HttpGet]
        [Route("{id:int}/question")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<Verification> GetVerificationQuestionByMemberId(int id)
        {
            var response = VerificationData.verifications.Where(x => x.OwnerId == id).FirstOrDefault();

            if (response == null)
            {
                return NotFound("no verification code on file");
            }

            return response;
        }


        /// <summary>
        /// Gets the opening question for a verification session
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns>question and answer based on member profile</returns>

        [HttpGet]
        [Route("opener/{ownerId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<string> GetVerificationQuestionsByMemberId(int ownerId)
        {
            var openingQuestion = new QuestionBuilder(ownerId);
            // Refactor QuestionBuilder to accept a constructor of memberId
            // then pass the member Id to the Build function that you'll create
            // the build function will generate 3 primary questions and 2 secondary questions
            // Also don't forget to refactor code for maintenace when you are done
            // in the util folder, create functions - GetTransactions,GetTransactionType,GetHomeBranch e.t.c.
            //var ans = openingQuestion.GetOpeningQuestionAndAnswer();
            var ans = openingQuestion.BuildQuestions();

            //Answer answer = openingQuestion.GetOpeningQuestionAndAnswer();



            return ans; //_mapper.Map<AnswerDTO>(ans);
        }

        /// <summary>
        /// Creates a new verification question and answer
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
        /// <param name="ownerId"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("create/{ownerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Verification> CreateVerificationQuestionAndAnswer(int ownerId,string question,string answer)
        {
            var member = MemberData.MemberList.Where(x => x.Id == ownerId).FirstOrDefault();
            if(member == null) { return NotFound($"Member with {ownerId} does not exsit"); }

            var curQuestion = VerificationData.verifications.Where(x => x.OwnerId == ownerId).FirstOrDefault();

            if(string.IsNullOrEmpty(curQuestion?.VerificationQuestion))
            {
                VerificationData.verifications.Add(new Verification()
                {
                    OwnerId = ownerId,
                    VerificationQuestion = question,
                    Answer = answer,
                    LastUpdated = DateOnly.FromDateTime(DateTime.Now)

                });
            }
            return Ok($"Verification code for memberId {ownerId} created successfully");
        }



        /// <summary>
        /// updates verification question and answer for specified member id
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
        /// <param name="ownerId"></param>
        /// <returns></returns>

        [HttpPut]
        [Route("update/{ownerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Verification> UpdateVerificationQuestionAndAnswer(int ownerId, string question, string answer)
        {
            var member = MemberData.MemberList.Where(x => x.Id == ownerId).FirstOrDefault();
            if (member == null) { return NotFound($"Member with id {ownerId} does not exsit"); }

            var curQuestion = VerificationData.verifications.Where(x => x.OwnerId == ownerId).FirstOrDefault();
            if(curQuestion?.OwnerId != null)
            {
                curQuestion.VerificationQuestion = question;
                curQuestion.Answer = answer;
            }
            else
            {
                return NotFound($"No verification code on file for member id {ownerId}");
            }
            return Ok($"Verification code for member Id {ownerId} updated successfully");
        }


    }
}
