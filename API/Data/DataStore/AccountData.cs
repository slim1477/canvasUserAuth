using System;
using MemberVerify.Enums;
using MemberVerify.Models;
using Microsoft.VisualBasic;


namespace MemberVerify.Data.DataStore
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
                Balance = 300,
                OwnerId = MemberData.MemberList.Last().Id
            },
              new CheckingAccount()
            {
                AccountNumber = 3222549,
                AccountName = "Checking",
                AccountDescription = "Checking Account",
                Type = ProductType.Checking.ToString(),
                Balance = 1100,
                OwnerId = MemberData.MemberList.First().Id
            },
               new CheckingAccount()
            {
                AccountNumber = 222549,
                AccountName = "Checking",
                AccountDescription = "Checking Account",
                Type = ProductType.Checking.ToString(),
                Balance = 2560,
                OwnerId = MemberData.MemberList.Last().Id
            },
               new AutoLoan()
               {
                   AccountNumber = 3232322,
                   AccountDescription = "Auto Loan",
                   Type = ProductType.Lending.ToString(),
                   AccountName = "Auto Loan",
                   AutoType = "Lexus 2010",
                   AmountDue = 250,
                   Balance = 25000,
                   DueDate = DateOnly.Parse("2024/03/01"),
                   MaturityDate = DateOnly.Parse("2028/03/01"),
                   OwnerId = MemberData.MemberList.First().Id,
                   InterestRate = .35,
                   PaymentFrequency = "biweekly"


               }
        };
    };
}
