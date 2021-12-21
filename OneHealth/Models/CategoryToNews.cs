using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class CategoryToNews
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("NewsCategory")]
        public int NewsCategoryId { get; set; }
        public NewsCategory NewsCategory { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }



    }
}
