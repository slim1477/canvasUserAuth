namespace MemberVerify.Models.Response
{
    public class Account
    {
        public int OwnerId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public int AccountNumber { get; set; }
        public string AccountDescription { get; set; } = string.Empty;

        public double Balance { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
