using MemberVerify.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MemberVerify
{
    /// <summary>
    /// Represents a checking account
    /// </summary>
    public class CheckingAccount : IAccount
    {
        [Key]
        public int AccountNumber { get; set; }
        [Required]
        public string AccountName { get; set; } = string.Empty;

        [Required]
        public string AccountDescription { get; set; } = string.Empty;

        [Required]
        public double Balance { get ; set ; }

        [Required]
        public string Type { get; set; } = string.Empty;

        [Required]
        public int OwnerId { get; set; }
    }
}
