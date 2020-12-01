using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace _3.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int area { get; set; }

        public int destination { get; set; }
    }
}