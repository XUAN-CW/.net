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
        public int Id { get; set; }

        public string shipname { get; set; }

        public int load { get; set; }

        public string shiptype { get; set; }

        public int madetime { get; set; }
    }
}