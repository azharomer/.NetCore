using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Required,StringLength(200)]
        public string name { get; set; }

        [Required, StringLength(200),DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required, StringLength(200), DataType(DataType.PhoneNumber)]
        public string mobile { get; set; }

     
    }
}
