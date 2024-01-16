using MemberVerify.Models;
using Microsoft.AspNetCore.Mvc;




namespace MemberVerify
{
    /// <summary>
    /// Represents API routes/end points for member
    /// </summary>
    [ApiController]
    [Route("apiv1")]
    public class MemberController(IMemberVerifyRepo repo) : ControllerBase
    {
       
        /// <summary>
        /// Gets all members in the database
        /// </summary>
        /// <returns> List of members</returns>
        [HttpGet]
        [Route("members")]
        [ProducesResponseType(typeof(IEnumerable<Member>),StatusCodes.Status200OK)]
        [ProducesResponseType( StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<IEnumerable<Member>> GetAllMembers() 
        {
            
            return Ok(repo.GetAllMembers());
            
        }


        /// <summary>
        /// Gets member by first name and last name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>member with specified search parameter and returns a 404 — Not Found if not found</returns>
        [HttpGet]
        [Route("{firstName:alpha},{lastName:alpha}")]
        [ProducesResponseType(typeof(IEnumerable<Member>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Member> GetMemberByFirstName(string firstName,string lastName)
        {
            Member member =  repo.GetMemberByFirstName(firstName);
            if (member == null)
            {
                return NotFound($"Member with name {firstName} + {" "} + {lastName} does not exsit");
            }
            
            return Ok(member);
        }

        /// <summary>
        /// Gets member by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>member with specified search parameter and returns a 404 — Not Found if not found</returns>

        [HttpGet]
        [Route("profile/{id:int}")]
        [ProducesResponseType(typeof(IEnumerable<Member>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Member> GetMemberById(int id)
        {
            Member member = repo.GetMemberById(id);
            if (member == null)
            {
                return NotFound($"Member with id {id} does not exsit");
            }
            return Ok(member);
        }

        /// <summary>
        /// Gets member by phone number
        /// </summary>
        /// <param name="phonenumber"></param>
        /// <returns>member with specified search parameter and returns a 404 — Not Found if not found</returns>

        [HttpGet]
        [Route("profile")]
        [ProducesResponseType(typeof(IEnumerable<Member>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Member> GetMemberByPhoneNumber(string phonenumber)
        {
            Member member = repo.GetMemberByPhoneNumber(phonenumber);
            if (member == null)
            {
                return NotFound($"Member with phone number {phonenumber} does not exsit");
            }
            return Ok(member);
        }
    }
}
