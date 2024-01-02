using MemberVerify.Models;

namespace MemberVerify.Repository
{
    public interface IMemberVerifyRepo
    {
        List<Member> GetAllMembers();
        Member GetMemberByFirstName(string firstname);
        Member GetMemberById(int Id);
    }
}
