



using MemberVerify.Enums;

namespace MemberVerify
{
    /// <summary>
    /// Represents a Personal Loan
    /// </summary>
    public class PersonalLoan : IAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get ; set; } = string.Empty;
        public string AccountDescription { get; set; } = string.Empty;
        public double Balance { get; set; }
        public ProductType Type { get; set; }
        public int OwnerId { get; set; }
        public string PaymentFrequency { get; set; } = string.Empty;
        public double InterestRate { get; set; }
        public double AmountDue { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly MaturityDate { get; set; }
    }
}
