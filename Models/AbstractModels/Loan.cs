namespace MemberVerify.Models.AbstractModels
{
    public abstract class Loan : IAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public string AccountDescription { get; set; } = string.Empty;
        public double Balance { get; set; }
        public string Type { get; set; } = string.Empty;
        public int OwnerId { get; set; }
        public string PaymentFrequency { get; set; } = string.Empty;
        public double InterestRate { get; set; }
        public double AmountDue { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly MaturityDate { get; set; }
    }
}
