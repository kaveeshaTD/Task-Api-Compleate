using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.Services.Models;

namespace TaskApi.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest =>dest.Addrss,opt => opt.MapFrom(src => $"{src.AddrssNo},{src.street},{src.city}"));

            //create add author mapping
            CreateMap<CreateAuthorDto, Author>();
        }
    }
}
