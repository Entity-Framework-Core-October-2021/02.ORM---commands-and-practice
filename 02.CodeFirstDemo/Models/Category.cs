using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _02.CodeFirstDemo.Models
{
    public class Category
    {
        public Category()
        {
            this.News = new HashSet<News>();
        }
        [Key]
        public int Id { get; set; }
        
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
