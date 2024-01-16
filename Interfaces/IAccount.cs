
using MemberVerify.Enums;

namespace MemberVerify
{
    /// <summary>
    /// Represents the basic properties of an account
    /// </summary>
    public interface IAccount
    {
        int AccountNumber { get; set; }
        string AccountName { get; set; }
        string AccountDescription { get; set; }
        double Balance { get; set; }
        ProductType Type { get; set; }
        int OwnerId { get; set; }
    }
}
