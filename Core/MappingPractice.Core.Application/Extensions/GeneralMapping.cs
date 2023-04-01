using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapping.Practice.WemApi.Extensions
{
  
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<MappingPractice.Core.Domain.Models.User, MappingPractice.Core.Application.Dtos.UserDto>()
                .ForMember(x => x.Name, y => y.MapFrom(z =>  "Sayın "  + z.Name ))
                //.ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ReverseMap();
        }
    }
}