using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public ICollection<BlogComment> BlogComments { get; set; }   //Bir kullanıcı birden fazla bloğa yorum yapabilir.
        public ICollection<ProductComment> ProductComments { get; set; }   //Bir kullanıcı birden fazla ürüne yorum yapabilir.
    }
}
