using MemeberVerify.Models;

namespace MemeberVerify.Data.DataStore
{
    public static class VerificationData
    {
        public static IEnumerable<Verification> Verifications = new List<Verification>()
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
