using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class LessonValidator:AbstractValidator<Lesson>
    {
        public LessonValidator() 
        {
            RuleFor(l=>l.Name).NotEmpty();
            RuleFor(l => l.Name).MinimumLength(3);
            RuleFor(l => l.Price).GreaterThan(100);
        }

    }
}
