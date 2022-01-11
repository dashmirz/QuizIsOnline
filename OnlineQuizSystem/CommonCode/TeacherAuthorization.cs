using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineQuizSystem.CommonCode
{
    public class TeacherAuthorization : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (SessionManager.teacher == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "AdminAccount",
                    action = "Login",
                    area = "Admin"
                }));

            }


            base.OnActionExecuting(filterContext);
        }
    }
}