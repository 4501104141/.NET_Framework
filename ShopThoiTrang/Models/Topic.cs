using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopThoiTrang.Models
{
    [Table("Topics")]
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public int ParentID { get; set; }
        public int Orders { get; set; }
        [Required]
        public string Metakey { get; set; }
        [Required] // Bat buoc Metades nhap gia tri
        public string Metades { get; set; }
        public int? Create_By { get; set; }
        public DateTime Create_At { get; set; }
        public int? Update_By { get; set; }
        public DateTime? Update_At { get; set; }
        public int Status { get; set; }
    }
}