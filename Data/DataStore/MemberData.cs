using MemberVerify.Models;



namespace MemberVerify.Data.DataStore
{
    // Represents mock data set for members
    public static class MemberData
    {
        public static List<Member> MemberList = new()
        {
             new Member()
        {
            Id = 1,
            FirstName = "James",
            LastName = "Doe",
            DOB = DateOnly.Parse("12/22/1975"),
            Email = "james@gmail.com",
            PhoneNumber = "204-958-8588",
            Address = "123 Hargrave Avenue Winnipeg, Manitoba",
            MemberSince = DateOnly.Parse("3/05/2002")
        },
                   new Member()
        {
            Id = 2,
            FirstName = "Brain",
            LastName = "Whitaker",
            DOB = DateOnly.Parse("10/12/1985"),
            Email = "brain@gmail.com",
            PhoneNumber = "204-958-3866",
            Address = "425 test street Winnipeg, Manitoba",
            MemberSince = DateOnly.Parse("4/05/2022")
        }
    };
        
    }
}
