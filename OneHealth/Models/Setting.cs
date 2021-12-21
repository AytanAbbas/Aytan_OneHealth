using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(15)]
        public string Phone1 { get; set; }
        [MaxLength(15)]
        public string Phone2 { get; set; }
        [MaxLength(50)]
        public string Gmail1 { get; set; }
        [MaxLength(50)]
        public string Gmail2 { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [Column(TypeName ="ntext")]
        public string  About { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }



    }
}
