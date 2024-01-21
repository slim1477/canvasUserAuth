using AutoMapper;
using MemberVerify.Models.Response;
using MemberVerify.Models.DTOs;

namespace MemberVerify
{ 
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<Member,MemberDto>().ReverseMap();
            CreateMap<IAccount,AccountDto>().ReverseMap();
            
        } 
    }
}
