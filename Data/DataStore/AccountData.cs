using MemeberVerify.Models;


namespace MemeberVerify.Data.DataStore
{
    // Represents Demo account types
    public static class AccountData
    {
        public static List<Account> accounts = new List<Account>()
        {
            new()
            {
                AccountNumber = "112549",
                AccountName = "Every Day Savings",
                AccountDescription = "Day To Day Spending",
                Type = Models.Enums.ProductType.Savings,
                OwnerId = MemberData.MemberList.First()
            },
               new Account()
            {
                AccountNumber = "222549",
                AccountName = "Checking",
                AccountDescription = "Checking Account",
                Type = Models.Enums.ProductType.Checking,
                OwnerId = MemberData.MemberList.Last()
            }
        };
    };
}
