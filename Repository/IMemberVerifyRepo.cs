using MemberVerify.Models;

namespace MemberVerify.Repository
{
    public interface IMemberVerifyRepo
    {
        /// <summary>
        /// Gets all members in the database
        /// </summary>
        /// <returns>a list of memebrs</returns>
        List<Member> GetAllMembers();

        /// <summary>
        /// Gets member by first name
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns>member with specified first name</returns>
        Member GetMemberByFirstName(string firstname);

        /// <summary>
        /// Gets memebr by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>returns member with specified Id</returns>
        Member GetMemberById(int Id);

    }
}
