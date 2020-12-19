using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Student
    {
        [Display(Name = "id")]
        [Required(ErrorMessage = "必填")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "必须是6~10个字符")]
        public string id { get; set; }

        [Display(Name = "name")]
        [Required(ErrorMessage = "必填")]
        [StringLength(10)]
        public string name { get; set; }

        [Display(Name = "sex")]
        [Required(ErrorMessage = "必填")]
        [StringLength(1)]
        public string sex { get; set; }

        [Display(Name = "age")]
        [Required(ErrorMessage = "必填")]
        [Range(1, 100)]//数据范围验证信息
        public int age { get; set; }
    }

    //创建数据库上下文类，上下文类代码可以和Student类放在一起写
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}