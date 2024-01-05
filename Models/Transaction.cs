using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberVerify.Models
{
    /// <summary>
    /// REpresents a transaction
    /// </summary>
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        [Required]
        public string TransType { get; set; } = string.Empty;

        public string TransDesc { get; set;} = string.Empty;

        public double TransAmount { get; set; }

        public DateOnly TransDate { get; set; }






    }
}
