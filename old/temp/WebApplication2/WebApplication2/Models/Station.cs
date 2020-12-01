using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace WebApplication2.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public int area { get; set; }

        public int destination { get; set; }
    }
}