using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data.SqlClient;

namespace SAUU.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            string message;
            var sqlException = context.Exception.InnerException as SqlException;
            if (sqlException != null && (sqlException.Number == 2627 || sqlException.Number == 2601))
                message = "Error de duplicidad, se está intentando crear un registro duplicado!";
            else
            {
                if (context.Exception.InnerException == null)
                    message = context.Exception.Message;
                else
                    message = context.Exception.InnerException.Message;
            }

            context.Result = new RedirectResult("/Home/Error");
        }
    }
}
