using MemberVerify.Models;
using MemberVerify.Data.DataStore;
namespace MemberVerify.Repository
{

    /// <summary>
    /// Represents member data hub for member information
    /// </summary>
    
    public class MemberVerifyRepo : IMemberVerifyRepo
    {
        public List<Member> GetAllMembers()
        {
            
           return MemberData.MemberList ;
        }


        public Member GetMemberById(int Id)
        {
            return MemberData.MemberList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public Member GetMemberByFirstName(string firstname)
        {
            return MemberData.MemberList.Where(fn => fn.FirstName.ToLower() == firstname.ToLower()).FirstOrDefault();
        }
    }
}
