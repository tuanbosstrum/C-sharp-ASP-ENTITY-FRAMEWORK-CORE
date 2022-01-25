using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace doan_asp.net.Models
{
    public class Tintuc
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Tiêu đề")]
        public string Tieude { get; set; }
        [Required, DisplayName("Nội dung")]
        public string Noidung { get; set; }
        [Required, DisplayName("Hình ảnh")]
        public string Hinhanh{get; set; }

    }
}
