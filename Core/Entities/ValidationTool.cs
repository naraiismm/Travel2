﻿using Core.Entities.Abstract;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public static class ValidationTool<T>where T: class,IEntity,new()
    {
        public static void Validation(IValidator validator,T entity)
        {
           var validationContext =new ValidationContext<T>(entity);
            var result=validator.Validate(validationContext);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
