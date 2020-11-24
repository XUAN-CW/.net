using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PRJ037.Models
{
    public class shiptable037
    {

        [Key]
        public int id { get; set; }
        public int shipname { get; set; }
        public int load { get; set; }
        public int shiptype { get; set; }
        public int madetime { get; set; }
    }
}