﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).Length(1, 15).NotNull();
            RuleFor(x => x.LastName).Length(1, 15).NotNull();
            RuleFor(x => x.BirthDate).LessThan(DateTime.Now).GreaterThanOrEqualTo(new DateTime(1900,1, 1));

        }
    }
}
