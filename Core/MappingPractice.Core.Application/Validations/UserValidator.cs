using FluentValidation;
using MappingPractice.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MappingPractice.Core.Application.Validations
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEqual("Peygamber").WithMessage("Dini terimler yasaktır");
            RuleFor(x => x.Id).LessThanOrEqualTo(100).WithMessage("Id 100den büyük olamaz");
        }
    }
}
