using MemberVerify.Models;

namespace MemberVerify.Data.DataStore
{
    /// <summary>
    /// Represents demo verification information
    /// </summary>
    public static class VerificationData
    {
        /// <summary>
        /// Represents mock verification data
        /// </summary>
        public static List<Verification> Verifications = new List<Verification>()
        {
            new()
            {
                Id = 1,
                VerificationQuestion = "What is the name of your pet?",
                Answer = "Bingo",
                LastUpdated = DateOnly.Parse("03/22/2021"),
                OwnerId = MemberData.MemberList.First()

            },

        };
    }
}
