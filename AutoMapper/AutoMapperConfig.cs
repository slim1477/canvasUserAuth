using AutoMapper;
using MemberVerify.Models;
using MemberVerify.Models.DTOs;

namespace MemberVerify
{ 
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<Member,MemberDto>().ReverseMap();
            CreateMap<SavingsAccount,AccountsDto>().ReverseMap();
            CreateMap<CheckingAccount,AccountsDto>();
        } 
    }
}
