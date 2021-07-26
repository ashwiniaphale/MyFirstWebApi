using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi.Model
{
    public class Employee
    {
        [Key] 
        public int ID { get; set; }
        public string name { get; set; }
        public string department { get; set; }
    }
}
