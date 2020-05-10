using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDay3.Models
{
    public enum Gender
    {
        Male,Female
    }
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(1200,50000)]
        public int Salary { get; set; }
        [MaxLength(128)]
        public string Address { get; set; }
        public Gender Gender { get; set; }
    }
}