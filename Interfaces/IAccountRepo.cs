



namespace MemberVerify
{

    /// <summary>
    /// Represents the actions of the account repo
    /// </summary>
    public interface IAccountRepo
    {
        /// <summary>
        /// Gets a list of Accounts
        /// </summary>
        /// <returns></returns>
        List<IAccount> GetAllAccounts();

        /// <summary>
        /// Gets account with specified account number
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IAccount GetAccountByAccountNumber(int id);

        /// <summary>
        /// Gets account and associated transactions with specified Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<IAccount> GetAccountAndTransactions(int id);

        /// <summary>
        /// Gets accounts for specified member id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<IAccount> GetAccountByMemberId(int id);

    }
}
