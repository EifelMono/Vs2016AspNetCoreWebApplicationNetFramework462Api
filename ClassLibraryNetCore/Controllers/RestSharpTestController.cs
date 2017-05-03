using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNetCore.Controllers
{
    /// <summary>
    /// RestSharpTestController
    /// </summary>
    [Route("api/[controller]")]
    public class RestSharpTestController : Controller
    {
        /// <summary>
        /// Test with jsontest server
        /// </summary>
        /// <returns></returns>
        [HttpGet("ipjsontest")]
        public async Task<string> IpJsonTest()
        {
            var client = new RestClient("http://ip.jsontest.com/");
            var request = new RestRequest("", Method.GET);
            var response = await client.ExecuteTaskAsync<string>(request);
            return response.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        public string Get()
        {
            return "x";
        }
    }
}
