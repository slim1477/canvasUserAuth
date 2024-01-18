using Microsoft.AspNetCore.Mvc;
using MemberVerify.Models;




namespace MemberVerify
{

    [ApiController]
    [Route("accounts")]
    public class AccountsController : ControllerBase
    {

        /// <summary>
        /// Gets accounts for specified member Id
        /// </summary>
        /// <returns> List of members</returns>
        [HttpGet]
        [Route("{id:int}/account")]
        [ProducesResponseType(typeof(IEnumerable<AccountsDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public  ActionResult<AccountsDto> GetMemberAccountById(int id)
        {
            AccountsDto accounts = MemberVerifyRepo.GetAccountByMemberId(id);
            

            if (accounts.FirstName == null) 
            {
                return NotFound($"Member with id {id} does not exsit");
            }
            return Ok(accounts);                                   
        }

    }
}
