




using MemberVerify.Data.DataStore;

namespace MemberVerify.Repository
{
    public class AccountRepo : IAccountRepo
    {
        public List<IAccount> GetAccountAndTransactions(int id)
        {
            throw new NotImplementedException();
        }

        public IAccount GetAccountByAccountNumber(int acctNum)
        {
            return AccountData.accounts.Where(account => account.AccountNumber == acctNum).FirstOrDefault();
        }

        public List<IAccount> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets accounts for specified member id
        /// </summary>
        /// <param name = "id" ></ param >
        /// < returns ></ returns >
        public List<IAccount> GetAccountByMemberId(int id)
        {
            var account = AccountData.accounts.Where(account => account.OwnerId == id).ToList();
            //var result = MemberData.MemberList.Join(AccountData.accounts,
            //                                     member => member.Id,
            //                                     account => account.OwnerId,
            //                                     (member, account) => new { member, account })
            //                                     .Where(member => member.member.Id == id);
            

            //var accounts = new AccountsDto()
            //{
            //    MemberId = result.Select(x => x.member.Id).FirstOrDefault(),
            //    FirstName = result.Select(x => x.member.FirstName).FirstOrDefault(),
            //    LastName = result.Select(x => x.member.LastName).FirstOrDefault(),
            //    Accounts = result.Select(x => x.account).ToList()
            //};
            //return result;

            return account;

        }

    
    }
}
