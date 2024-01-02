using MemberVerify.Models;
using Microsoft.AspNetCore.Mvc;
using MemberVerify.Repository;



namespace MemberVerify.Controllers
{
    /// <summary>
    /// Represents API routes/end points for the application
    /// </summary>
    [ApiController]
    [Route("/apiv1/[Controller]")]
    public class MemberController(IMemberVerifyRepo repo) : ControllerBase
    {
       
        /// <summary>
        /// Gets all members in the database
        /// </summary>
        /// <returns> List of members</returns>
        [HttpGet]
        [Route("/members")]
        [ProducesResponseType(typeof(IEnumerable<Member>),StatusCodes.Status200OK)]
        [ProducesResponseType( StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<IEnumerable<Member>> GetAllMembers() 
        {
            
            return Ok(repo.GetAllMembers());
            
        }


        /// <summary>
        /// Gets member by  first name
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns>member with specified search parameter and returns a 404 — Not Found if not found</returns>
        [HttpGet]
        [Route("{firstName:alpha}")]
        [ProducesResponseType(typeof(IEnumerable<Member>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Member> GetMemberByFirstName(string firstName)
        {
            Member member =  repo.GetMemberByFirstName(firstName);
            if (member == null)
            {
                return NotFound($"Member with first name {firstName} does not exsit");
            }
            
            return Ok(member);
        }

        /// <summary>
        /// Gets member by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>member with specified search parameter and returns a 404 — Not Found if not found</returns>

        [HttpGet]
        [Route("{id:int}/profile")]
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
    }
}
