using Microsoft.AspNetCore.Mvc;
using AutoMapper;




namespace MemberVerify
{

    [ApiController]
    [Route("api/v1")]
    public class AccountsController(IAccountRepo repo,IMapper _mapper) : ControllerBase
    {

        /// <summary>
        /// Gets accounts for specified member Id
        /// </summary>
        /// <returns> List of member accounts</returns>
        [HttpGet]
        [Route("{id:int}/account")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<AccountDto>> GetMemberAccountById(int id)
        {
            

            var result = repo.GetAccountByMemberId(id);
            


            if (result.Count < 1)
            {
                return NotFound($"Member with id {id} does not have any accounts yet");
            }
            return Ok(_mapper.Map<List<AccountDto>>(result));
        }

        /// <summary>
        /// Gets account for specified account number
        /// </summary>
        /// <returns> specified account with account number</returns>
        [HttpGet]
        [Route("account/{acctNum:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IAccount> GetAccountByAccountNumber(int acctNum)
        {
            var result = repo.GetAccountByAccountNumber(acctNum);

            if(result == null) { return NotFound($"Account with {acctNum} does not exsits"); }

            return Ok(result);
        }

    }
}
