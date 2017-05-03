using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vs2016AspNetCoreWebApplicationNetFramework462Api.Controllers
{
    /// <summary>
    /// Swagger controller.
    /// </summary>
    public class SwaggerController : Controller
    {
        /// <summary>
        /// The SwaggerController help from / to swagger
        /// </summary>
        public SwaggerController()
        {
        }

        /// <summary>
        /// Redirect to Swagger
        /// </summary>
        /// <returns>The root.</returns>
        [HttpGet("/")]
        public ActionResult Root()
        {
            return Redirect("swagger/ui/index.html");
        }
    }
}
