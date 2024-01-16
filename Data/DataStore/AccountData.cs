
using MemberVerify.Enums;
using MemberVerify.Data.DataStore;


namespace MemberVerify
{
    // Represents Demo account types
    public static class AccountData
    {
        public static List<IAccount> accounts = new()
        {
            new SavingsAccount()
            {
                AccountNumber = 112549,
                AccountName = "Every Day Savings",
                AccountDescription = "Day To Day Spending",
                Type = ProductType.Savings.ToString(),
                Balance = 200,
                OwnerId = MemberData.MemberList.First().Id
            },
             new SavingsAccount()
            {
                AccountNumber = 119949,
                AccountName = "Every Day Savings",
                AccountDescription = "Day To Day Spending",
                Type = ProductType.Savings.ToString(),
                OwnerId = MemberData.MemberList.Last().Id
            },
              new CheckingAccount()
            {
                AccountNumber = 3222549,
                AccountName = "Checking",
                AccountDescription = "Checking Account",
                Type = ProductType.Checking.ToString(),
                OwnerId = MemberData.MemberList.First().Id
            },
               new CheckingAccount()
            {
                AccountNumber = 222549,
                AccountName = "Checking",
                AccountDescription = "Checking Account",
                Type = ProductType.Checking.ToString(),
                OwnerId = MemberData.MemberList.Last().Id
            }
        };
    };
}
