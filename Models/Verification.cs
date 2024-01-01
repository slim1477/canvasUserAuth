using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemeberVerify.Models
{
    public class Verification
    {
        [Key]
        public int Id { get; set; }

        
        [ForeignKey("Member")]
        [Required]
        public required Member OwnerId {  get; set; }

        [Required(ErrorMessage ="This is a required Field")]
        public string VerificationQuestion { get; set; } = String.Empty;

        [Required(ErrorMessage ="This is a required Field")]
        public string Answer { get; set; } = string.Empty;

        public DateOnly LastUpdated { get; set; }
    }
}
