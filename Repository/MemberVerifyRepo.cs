using MemberVerify.Models;
using MemberVerify.Data.DataStore;
namespace MemberVerify.Repository
{

    /// <summary>
    /// Represents member data hub for member information
    /// </summary>
    
    public class MemberVerifyRepo : IMemberVerifyRepo
    {
        /// <summary>
        /// Gets all members from the database
        /// </summary>
        /// <returns>A list of members</returns>
        public List<Member> GetAllMembers()
        {
            
           return MemberData.MemberList ;
        }

        /// <summary>
        /// Gets a member by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>member with specified Id</returns>
        public Member GetMemberById(int Id)
        {

            
            return MemberData.MemberList.Where(m => m.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Gets member by first name
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns>member with specified first name</returns>
        public Member GetMemberByFirstName(string firstname)
        {
            return MemberData.MemberList.Where(fn => fn.FirstName.ToLower() == firstname.ToLower()).FirstOrDefault();
        }
    }
}
