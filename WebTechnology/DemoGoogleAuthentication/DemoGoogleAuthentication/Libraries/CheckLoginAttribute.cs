using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGoogleAuthentication.Libraries
{
    public class CheckLoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if(filterContext.HttpContext.Session["userid"] == null)
            {
                filterContext.Result = new RedirectResult("/OAuth/Index");
            }
        }

    }
}