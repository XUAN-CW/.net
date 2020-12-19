using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace review.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
}