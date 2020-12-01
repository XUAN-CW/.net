using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class T_Student
    {
        [Key]
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "学号")]
        public string Sno { get; set; }

        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "姓名")]
        public string Sname { get; set; }

        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "性别")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "qq号")]
        public string SQQ { get; set; }

        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "宿舍号")]
        public string Sdormitory { get; set; }

    }

    public class studentDBContext : DbContext
    {
        [Key]
        public DbSet<T_Student> students { get; set; }
    }
}