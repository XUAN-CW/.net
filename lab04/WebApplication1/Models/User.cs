using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
    public class Category 
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [Display(Name = "栏目ID")]
        [Required(ErrorMessage = "x")]
        public int CategoryId { get;  set; }
        [Display(Name = "来源")]
        [StringLength(255, ErrorMessage = "×")] 
        public string Source { get; set; }
        [Display(Name = "作者")] 
        [StringLength(50, ErrorMessage = "×")] 
        public string Author { get; set; } 
        
        [Display(Name = "摘要")] 
        public string Intro { get; set; } 
        [Display(Name = "内容")] 
        [Required(ErrorMessage = "×")] 
        [DataType(DataType.Html)] 
        public string Content { get; set; }
    }
    public class userDBContext : DbContext 
    { 
        public DbSet<User> Users { get; set; } 
        public DbSet<Category> Categorys { get; set; } 
        public DbSet<Article> Articles { get; set; }
    }

}