
using MemberVerify.Models;




namespace MemberVerify.Data.DataStore
{
    public static class TransactionData
    {
        public static List<Transaction> transactions =
    [
      new ()
      {
        Id = 1,
        AccountId = AccountData.accounts.First().AccountNumber,
        TransType = "External Deposit",
        TransAmount = 100,
        TransDate = DateOnly.Parse("05/01/2023"),
        TransDesc = "Paycheck Deposit"

      },
      new ()
      {
        Id = 2,
        AccountId = AccountData.accounts.First().AccountNumber,
        TransType = "Withdrawal",
        TransAmount = 50,
        TransDate = DateOnly.Parse("05/10/2023"),
        TransDesc = "7 Eleven purchase"
      },
      new ()
      {
        Id = 3,
        AccountId = AccountData.accounts.Last().AccountNumber,
        TransType = "Withdrawal",
        TransAmount = 50,
        TransDate = DateOnly.Parse("05/10/2023"),
        TransDesc = "7 Eleven purchase"
      }
    ];
    }
}