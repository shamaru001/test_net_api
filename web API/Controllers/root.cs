//using System;
//using System.Security.Cryptography.X509Certificates;
using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.OpenApi.Any;

namespace web_API.Controllers
{
    [ApiController]
    [Route("/shamaru")]
    public class Root : ControllerBase
    {
        [HttpGet(Name = "shamaru 2")]
        public string Get()
        {
            
            Console.WriteLine(HttpContext.Request.Headers);

            foreach (KeyValuePair<string, StringValues> a in HttpContext.Request.Headers)
            {
                Console.WriteLine(a);
            }
            return "shamaru";
        }

        [HttpPost]
        public string Post()
        {
            return "post";
        }



    }
}
