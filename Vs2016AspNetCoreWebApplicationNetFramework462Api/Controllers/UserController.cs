using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vs2016AspNetCoreWebApplicationNetFramework462Api.Modul;

namespace Vs2016AspNetCoreWebApplicationNetFramework462Api.Controllers
{
    /// <summary>
    /// My User Controller
    /// </summary>
    [Route("api/user")]
    public class UserController : Controller
    {
        static User CurrentUser = new User();

        /// <summary>
        /// Gets the controller current user
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        public User Get()
        {
            return CurrentUser;
        }

        /// <summary>
        /// Sets the controller current user by user object
        /// </summary>
        /// <param name="user"></param>
        [HttpPut("setuser")]
        public void SetUser([FromBody] User user)
        {
            CurrentUser = user;
        }
        /// <summary>
        /// Sets the controller current user by single element
        /// </summary>
        /// <param name="user"></param>
        [HttpPut("set/{name}/{city}/{email}")]
        public void SetUserByElements(string name, string city, string email)
        {
            CurrentUser = new Modul.User { Name = name, City = city, Email = email };
        }

        /// <summary>
        /// Return the controller current user object
        /// </summary>
        /// <returns></returns>
        [HttpGet("getuser")]
        public User GetUser()
        {
            return CurrentUser;
        }
    }
}
