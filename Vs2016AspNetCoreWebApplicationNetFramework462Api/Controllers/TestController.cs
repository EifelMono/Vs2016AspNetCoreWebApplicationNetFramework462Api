using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vs2016AspNetCoreWebApplicationNetFramework462Api.Controllers
{
    /// <summary>
    /// TestGenericResult Controller
    /// </summary>
    [Route("api/TestGenericResult")]
    public class TestGenericResultController: Controller
    {

        /// <summary>
        /// GetStringGenericResult
        /// </summary>
        /// <returns></returns>
        [HttpGet("getstring")] 
        public GenericResult<string> GetString()
        {
            return new GenericResult<string> { Result = "GetStringGenericResult" };
        }

        /// <summary>
        /// GetIntGenericResult
        /// </summary>
        /// <returns></returns>
        [HttpGet("getint")]
        public GenericResult<int> GetInt()
        {
            return new GenericResult<int> { Result = 4711 };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("ClassLibrary462Class1Name")]
        public string GetClassLibrary462Class1Name()
        {
            return ClassLibrary462.Class1.Name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("ClassLibraryPclClass1Name")]
        public string GetClassLibraryPclClass1Name()
        {
            return ClassLibraryPcl.Class1.Name;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericResult<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public T Result { get; set; }
    }
}
