using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vs2016AspNetCoreWebApplicationNetFramework462Api.Modul
{
    /// <summary>
    /// User Class
    /// </summary>
    public class User
    {
        /// <summary>
        /// The Name of the user
        /// </summary>
        [Required]
        public string Name { get; set; }


        /// <summary>
        /// The City of the user
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// The EMail of the user
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// The Phone of the user
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// A Comment to the user
        /// </summary>
        public string Comment { get; set; }
    }
}
