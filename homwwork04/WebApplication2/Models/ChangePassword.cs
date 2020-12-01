using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ChangePassword
    {
        [NotMapped]
        //原密码 
        [Display(Name = "原密码")]
        [Required(ErrorMessage = "x")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "x")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //新密码 
        [Display(Name = "新密码", Description = "6-20 个字符")]
        [Required(ErrorMessage = "x")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "x")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        //确认密码
        [Display(Name = "确认密码", Description = "再次输入密 码")]
        [Compare("NewPassword", ErrorMessage = "x")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}