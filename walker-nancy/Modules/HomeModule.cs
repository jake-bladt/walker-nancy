﻿using System;
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
            Get["/"] = _ => View["Index"];
        }
    }
}
