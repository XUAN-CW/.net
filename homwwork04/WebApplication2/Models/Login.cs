using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Login
    {
        //用户名
        [Display(Name = "用户名", Description = "6-20 个字符。")]
        [Required(ErrorMessage = "字符个数为6-20，请重新输入")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "字符个数为6-20，请重新输入")]
        public string UserName { get; set; }
        //密码 
        [Display(Name = "密码", Description = "6-20 个字符。")]
        [Required(ErrorMessage = "字符个数为6-20，请重新输入")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "字符个数为6-20，请重新输入")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}