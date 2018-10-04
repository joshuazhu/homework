using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace WebMvc
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            if(exception is InvalidDataException)
            {
                //todo log warning
            }
            else
            {
                //todo log error
            }

            base.OnException(context);
        }
    }
}
