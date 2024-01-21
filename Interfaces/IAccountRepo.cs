



namespace MemberVerify
{

    /// <summary>
    /// Represents the actions of the account repo
    /// </summary>
    public interface IAccountRepo
    {
        /// <summary>
        /// Gets account with specified account number
        /// </summary>
        /// <param name="acctNum"></param>
        /// <returns></returns>
        IAccount GetAccountByAccountNumber(int acctNum);

        

        /// <summary>
        /// Gets accounts for specified member id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<IAccount> GetAccountByMemberId(int id);

    }
}
