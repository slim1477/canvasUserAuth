using MemberVerify.Enums;
using MemberVerify.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberVerify
{
    /// <summary>
    /// Represents an account
    /// </summary>
    public class SavingsAccount : IAccount
    {
       
        [Key]
        public int AccountNumber { get; set; } 

        [Required]
        public string AccountName { get; set; } = string.Empty;

        public string AccountDescription { get; set; } = string.Empty;

        [Required]
        public  ProductType Type { get; set; }

        [Required]
        [ForeignKey("Member")]
        public required int OwnerId { get; set; }

        public double Balance { get; set; }
        
    }
}
