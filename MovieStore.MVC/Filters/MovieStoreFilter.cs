using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.MVC.Filters
{
    public class MovieStoreFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //check information of how many people came to the details page 
            var data = context.HttpContext.Request.Path;
            var someotherData = context.HttpContext.User.Identity.IsAuthenticated;

            //we can log this information in our text files or database
        }
    }
}
