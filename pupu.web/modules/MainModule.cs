using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace pupu.web.modules
{
    public class MainModule:NancyModule
    {
        public MainModule()
        {
            Get["/"] = p =>
            {
                return View["app/index.html"];
            };
        }
    }
}