namespace MemberVerify.Models.DTOs
{
    public class MemberDto
    {
        
        public int Id { get; set; }

       
        public string FirstName { get; set; } = string.Empty;

        
        public string LastName { get; set; } = string.Empty;

        
        public DateOnly DOB { get; set; }

       
        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public DateOnly MemberSince { get; set; }
    }
}
