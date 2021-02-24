using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        //Validasyon kuralları ctor içine yazılacak.
        public CarValidator()
        {
            //RuleFor(c => c.BrandName).Must(StartWithA); // Fluent validationda var olmayan bir validasyon.
           
            RuleFor(c => c.ModelName.Length).GreaterThan(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
