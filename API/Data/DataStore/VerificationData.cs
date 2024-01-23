using MemberVerify.Models;
using MemberVerify.Data.DataStore;

namespace MemberVerify
{
    /// <summary>
    /// Represents demo verification information
    /// </summary>
    public static class VerificationData
    {
        /// <summary>
        /// Represents mock verification data
        /// </summary>
        public static List<Verification> verifications = new()
        {
            new()
            {
                VerificationQuestion = "What is the name of your pet?",
                Answer = "Bingo",
                LastUpdated = DateOnly.Parse("03/22/2021"),
                OwnerId = MemberData.MemberList.First().Id

            },

        };
    }
}
