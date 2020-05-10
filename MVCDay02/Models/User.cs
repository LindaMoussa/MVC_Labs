using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2.Models
{
    public enum Gender { Male,Female}
    public class User
    {
       
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int salary { get; set; }
        public string address { get; set; }
        public Gender gender { get; set; }
    }
}