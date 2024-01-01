//using Microsoft.AspNetCore.Components;
using MemeberVerify.Models;
using Microsoft.AspNetCore.Mvc;
using MemeberVerify.Data.DataStore;
using System.Reflection.Metadata.Ecma335;


namespace MemeberVerify.Controllers
{
    [ApiController]
    [Route("/apiv1/[Controller]")]
    public class VerifyController() : ControllerBase
    {
        [HttpGet]
        [Route("/members")]
        public  ActionResult<IEnumerable<Member>> GeAllMembers() 
        {
            
            return Ok(MemberData.MemberList);
            
        }

        [HttpGet]
        [Route("{firstName:alpha}")]
        public ActionResult<Member> GetMemberByFirstName(string firstName)
        {
            Member member =  MemberData.MemberList.Where(mn => mn.FirstName.ToLower() == firstName.ToLower()).FirstOrDefault();
            if (member == null)
            {
                return NotFound($"Member with first name {firstName} does not exsit");
            }
            Console.WriteLine(member);
            return Ok(member);
        }

        [HttpGet]
        [Route("{id:int}/profile")]
        public ActionResult<Member> GetMemberById(int id)
        {
            Member member = MemberData.MemberList.Where(mn => mn.Id == id).FirstOrDefault();
            if (member == null)
            {
                return NotFound($"Member with id {id} does not exsit");
            }
            return Ok(member);
        }
    }
}
