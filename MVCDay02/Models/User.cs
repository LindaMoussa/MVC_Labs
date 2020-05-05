using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2.Models
{
    public enum Gender { Male,Female}
    public class User
    {
        public User()
        {

        }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int salary { get; set; }
        public string address { get; set; }
        public Gender gender { get; set; }
    }
}