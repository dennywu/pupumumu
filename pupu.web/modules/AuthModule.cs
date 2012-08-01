using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Responses;

namespace pupu.web.modules
{
    public class AuthModule : NancyModule
    {
        public AuthModule()
        {
            Get["/app/{file}"] = p =>
            {
                string filename = p.file.ToString();
                return Response.AsJs("app/app/" + filename);
            };
            Get["/sdk/{file}"] = p =>
            {
                string filename = p.file.ToString();
                return Response.AsJs("app/sdk/" + filename);
            };
            Get["/resources/{file}"] = p =>
            {
                string filename = p.file.ToString();
                return Response.AsJs("app/resources/" + filename);
            };
            Get["/app.js"] = p =>
            {
                string filename = p.file.ToString();
                return Response.AsJs("app/app.js");
            };
            Get["/app.json"] = p =>
            {
                string filename = p.file.ToString();
                return Response.AsJson("app/app.json");
            };
        }
    }
}