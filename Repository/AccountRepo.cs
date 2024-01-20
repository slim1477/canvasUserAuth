




using MemberVerify.Data.DataStore;

namespace MemberVerify
{
    public class AccountRepo : IAccountRepo
    {
        public List<IAccount> GetAccountAndTransactions(int id)
        {
            throw new NotImplementedException();
        }

        public IAccount GetAccountByAccountNumber(int id)
        {
            throw new NotImplementedException();
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

            throw new NotImplementedException();

        }

        List<IAccount> IAccountRepo.GetAccountByMemberId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
