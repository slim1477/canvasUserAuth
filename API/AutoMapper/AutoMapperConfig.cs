using AutoMapper;
using MemberVerify.Models.DTOs;
using MemberVerify.Models;
using MemberVerify.BusinessLogic;

namespace MemberVerify
{ 
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<Member,MemberDto>().ReverseMap();
            CreateMap<IAccount,AccountDto>().ReverseMap();
            CreateMap<Answer, AnswerDTO>().ReverseMap();

        } 
    }
}
