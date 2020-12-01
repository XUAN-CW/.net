using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
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
        //栏目id
        [Display(Name = "栏目ID")]
        [Required(ErrorMessage = "×")]
        public int CategoryId { get; set; }
        ///	来源	
        [Display(Name = "来源")]
        [StringLength(255, ErrorMessage = "×")]
        public string Source { get; set; }
        ///	作者	
        [Display(Name = "作者")]
        [StringLength(50, ErrorMessage = "×")]
        public string Author { get; set; }
        ///	摘要	
        

        [Display(Name = "摘要")]
        public string Intro { get; set; }
        	
        ///	内容	
        
        [Display(Name = "内容")]
        [Required(ErrorMessage = "×")]
        [DataType(DataType.Html)]
        public string Content { get; set; }

    }

    public class userDBContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}