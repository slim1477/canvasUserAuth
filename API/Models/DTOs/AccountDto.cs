using System;
using System.ComponentModel.DataAnnotations;

namespace MemberVerify
{ 

    /// <summary>
    /// Represents response schema for accounts
    /// </summary>
    public class AccountDto
    {
        public int OwnerId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public int AccountNumber { get; set; }
        public string AccountDescription { get; set; } = string.Empty;

        public double Balance { get; set; }
        public string Type { get; set; } = string.Empty;
        //public List<IAccount> Accounts { get; set; } = new();
    }
}
