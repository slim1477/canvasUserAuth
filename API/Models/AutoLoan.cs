



using MemberVerify.Models.AbstractModels;

namespace MemberVerify.Models
{
    /// <summary>
    /// Represents an Auto loan
    /// </summary>
    public class AutoLoan : Loan
    {
        public string AutoType { get; set; } = string.Empty;
    }
}
