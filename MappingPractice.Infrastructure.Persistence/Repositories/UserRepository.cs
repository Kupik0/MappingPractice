using AutoMapper;
using MappingPractice.Core.Application.Dtos;
using MappingPractice.Core.Application.Interfaces;
using MappingPractice.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingPractice.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper mapper;
   

        public UserRepository(IMapper Mapper)
        {
            mapper = Mapper;
            
        }
        public UserDto GetUserByIdMapper(int Id)
        {
            // Veritabanından Kaydın Getirilmesi

            User dbUser2 = getDummyUser();


      
            UserDto resultUser = mapper.Map<UserDto>(dbUser2);

            return resultUser;
        }
        public UserDto GetUserById(int Id)
        {
          User dbUser = getDummyUser();
            return new UserDto
            {
                Id = dbUser.Id,
                Name = dbUser.Name,
                Email = dbUser.Email,
            };
        }
        private User getDummyUser() {
            return new User()
            {
                Id = 1,
                Name = "Test",
                Email = "test@nulltech.com"
            };
        }
    }
}
