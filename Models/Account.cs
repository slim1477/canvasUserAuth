using MemberVerify.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberVerify.Models
{
    public class Account
    {
        [Key]
        public string AccountNumber { get; set; } = String.Empty;

        [Required]
        public string AccountName { get; set; } = string.Empty;

        public string AccountDescription { get; set; } = string.Empty;

        [Required]
        public  ProductType Type { get; set; }

        [Required]
        [ForeignKey("Member")]
        public required Member OwnerId { get; set; }
    }
}
