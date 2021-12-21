using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class NewsComment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Commenter")]
        public int CommenterId { get; set; }
        public Commenter Commenter { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }



    }
}
