using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace doan_asp.net.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Tên đăng nhập")]
        public string username { get; set; }
        [Required, DisplayName("Mật khẩu")]
        public string password { get; set; }
       
        
    }
}
