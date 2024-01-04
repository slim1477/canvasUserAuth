using System.ComponentModel.DataAnnotations;
using System.Security;

namespace MemberVerify.Models
{
    /// <summary>
    /// Represents a member
    /// </summary>
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; }   = string.Empty;

        [Required]
        public DateOnly DOB { get; set; }

        [EmailAddress]
        public string Email { get; set;} = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        public DateOnly MemberSince { get; set; }


        //public IEnumerable<AccountType> AccountType { get; set; } 

        //public IEnumerable<Accounts> Accounts { get; set; }
    }
}
