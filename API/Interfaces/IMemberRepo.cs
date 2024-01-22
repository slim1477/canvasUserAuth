using MemberVerify.Models;


namespace MemberVerify
{
    public interface IMemberRepo
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
        /// Gets member by first and last name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>Returns specified member with first and last name</returns>
        List<Member> GetMemberByFullName(string firstName, string lastName);

        /// <summary>
        /// Gets member by phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>Returns specofoed member by phone number</returns>
        Member GetMemberByPhoneNumber(string phoneNumber);

        /// <summary>
        /// Gets memebr by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>returns member with specified Id</returns>
        Member GetMemberById(int Id);

    }
}
