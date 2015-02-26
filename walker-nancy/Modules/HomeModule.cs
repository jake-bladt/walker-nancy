using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;

namespace Walker.Nancy.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                if (null == Context.CurrentUser)
                {
                    return Response.AsRedirect("/newuser");
                }
                else
                {
                    return View["Index"];
                }
            };

            Get["/newuser"] = _ => View["NewUser"];
        }
    }
}
