using MemberVerify.Models;
using MemberVerify.Data.DataStore;





namespace MemberVerify.Repository
{

    /// <summary>
    /// Represents member data repository for member information
    /// </summary>

    public class MemberRepo : IMemberRepo
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
        /// <returns>members with specified first name</returns>
        public Member GetMemberByFirstName(string firstname)
        {
            return MemberData.MemberList.Where(fn => fn.FirstName.ToLower().Contains(firstname.ToLower())).FirstOrDefault();
        }


        /// <summary>
        /// Gets member by first name and last name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>List of members with specified first name and last name</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Member> GetMemberByFullName(string firstName, string lastName)
        {
            return MemberData.MemberList.Where(m => m.FirstName.ToLower().Contains(firstName.ToLower()) 
                                                    & m.LastName.ToLower().Contains(lastName.ToLower())).ToList<Member>();
        }


        /// <summary>
        /// Gets member with specified phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>Returns a member with specified phone number</returns>
        public Member GetMemberByPhoneNumber(string phoneNumber)
        {
            return MemberData.MemberList.Where(m => m.PhoneNumber.ToLower() == phoneNumber.ToLower()).FirstOrDefault();
        }

      
    }
}
