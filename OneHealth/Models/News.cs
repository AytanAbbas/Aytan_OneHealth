using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [Column(TypeName ="ntext")]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustoMUser CustoMUser { get; set; }
        public List<TagToNews> TagToNews { get; set; }
        public List<CategoryToNews> CategoryToNews { get; set; }
        public List<NewsComment> NewsComments { get; set; }
    }
}
