using MemberVerify.Models;
using MemberVerify.Data.DataStore;



namespace MemberVerify.BusinessLogic.Util;
public static class VerificationAnswer
{
    ///<summary>
    /// Gets the Answer opening question for verifying a member
    ///</summary>
    public static List<string> AnswerToOpeningQuestion(int id)
    {
        // new System.Random().Next(1, 3) == 1 ? new Question(member, "What is your favorite color?", "

        return AccountData.accounts.Where(x => x.OwnerId == id).Select(x => x.Type.ToString()).ToList();

    }

    public static IEnumerable<IEnumerable<Transaction>> AnswerToTransactions(int id)
    {
        var transactions = AccountData.accounts.GroupJoin(TransactionData.transactions,
                                                        account => account.AccountNumber,
                                                        transaction => transaction.AccountId,
                                                        (account, transaction) => new { account, transaction })
                                                        .Where(x => x.account.OwnerId == id)
                                                        .Select(x => x.transaction);
        return transactions;
    }
}