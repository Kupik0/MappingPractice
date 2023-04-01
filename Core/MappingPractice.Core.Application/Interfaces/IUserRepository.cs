using MappingPractice.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingPractice.Core.Application.Interfaces
{
    public interface IUserRepository
    {
        public UserDto GetUserById(int Id);
        public UserDto GetUserByIdMapper(int Id);
       

    }
}
