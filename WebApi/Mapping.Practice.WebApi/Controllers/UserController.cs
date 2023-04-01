using MappingPractice.Core.Application.Dtos;
using MappingPractice.Core.Application.Interfaces;
using MappingPractice.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mapping.Practice.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository userRepository) 
        {
            this.userRepository = userRepository;
        }
        private readonly IUserRepository userRepository;
        //manuel mapping


        //[HttpGet("{Id}")]
        //public UserDto GetUserById(int Id)
        //{
        //    return userRepository.GetUserById(Id);



        //}

        //auto mapper

        [ResponseCache(Duration = 10)]
        [HttpGet("{Id}")]
        public UserDto GetUserByIdMapper(int Id)
        {
            return userRepository.GetUserByIdMapper(Id);



        }

        [HttpPost]
        public UserDto CreateUser(UserDto userDto)
        {

            return userDto;
        }
        
    }
}
