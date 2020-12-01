using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        /// 用户名 
        [Display(Name = "用户名", Description = "4-20个字符。")]
        [Required(ErrorMessage = "×")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "×")]
        public string UserName { get; set; }
        /// 密码
        [Display(Name = "密码")]
        [Required(ErrorMessage = "×")]
        [StringLength(512)]
        public string Password { get; set; }
        /// 性别【0-男；1-女；2-保密】 
        [Display(Name = "性别",Description = "0-男；1-女；2-保密")]
        [Required(ErrorMessage = "×")]
        [Range(0, 2, ErrorMessage = "×")]
        public byte Gender { get; set; } 
        /// Email 
         [Display(Name = "Email", Description = "请输入您常用的 Email。")]
        [Required(ErrorMessage = "×")]
        public string Email { get; set; } 
        /// 密保问题 
        [Display(Name = "密保问题", Description = "请正确填写，在 您忘记密码时用户找回密码。4-20个字符。")]
        [Required(ErrorMessage = "×")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "×")]
        public string SecurityQuestion { get; set; } 
        /// 密保答案
         [Display(Name = "密保答案", Description = "请认真填写，忘 记密码后回答正确才能找回密码。2-20个字符。")]
        [Required(ErrorMessage = "×")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "×")]
        public string SecurityAnswer { get; set; }
        /// QQ号码
        [Display(Name = "QQ号码",Description ="6-12位数")]
        // [RegularExpression("^[1-9][0-9]{4-13}$", ErrorMessage = "×")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "×")]
        public string QQ { get; set; } 
        /// 电话号码
        [Display(Name = "电话号码", Description = "常用的联系电话 （手机或固话），固话格式为：区号-号码。")]
        // [RegularExpression("^[0-9-]{11-13}$", ErrorMessage = "×")]
        public string Tel { get; set; } 
        /// 联系地址
        [Display(Name = "联系地址", Description = "常用地址，最多 80个字符。")]
        [StringLength(80, ErrorMessage = "×")]
        public string Address { get; set; }
        /// 邮编 
        [Display(Name = "邮编", Description = "6位字符。")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "×")]
        public string PostCode { get; set; } 
        /// 注册时间 
         public DateTime? RegTime { get; set; }
        /// 上次登录时间 
        public DateTime? LastLoginTime { get; set; }
    }

    public class reg:User
    {
        [Display(Name = "密码", Description = "6-20个字符。")]
        [Required(ErrorMessage = "×")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "×")]
        [DataType(DataType.Password)]
        public new string Password { get; set; } 
        /// 确认密码
        [Display(Name = "确认密码", Description = "再次输入密码。")]
        [Compare("Password", ErrorMessage = "×")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
    }

    public class userDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }

    public class UserLogin
    {
        [Display(Name = "用户名", Description = "4-20 个字符。")]
        [Required(ErrorMessage = "x")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "x")]
        public string UserName { get; set; }
        //密码 
        [Display(Name = "密码", Description = "6-20 个字符。")]
        [Required(ErrorMessage = "x")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "x")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

    public class UserChangePassword
    {
        [NotMapped]
        //原密码 
        [Display(Name = "原密码")] [Required(ErrorMessage = "x")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="x")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //新密码 
        [Display(Name = "新密码", Description = "6-20 个字符")]
        [Required(ErrorMessage = "x")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="x")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        //确认密码 
        [Display(Name = "确认密码", Description = "再次输入密码")]
        [Compare("NewPassword", ErrorMessage = "x")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}

