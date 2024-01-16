using System;

namespace MemberVerify
{ 

    /// <summary>
    /// Represents response schema for accounts
    /// </summary>
    public class AccountsDto
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public List<IAccount> Accounts { get; set; } = new();
    }
}
