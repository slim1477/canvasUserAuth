using MemberVerify.Models;

namespace MemberVerify.Data.DataStore
{
    // Represents demo verification information
    public static class VerificationData
    {
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
