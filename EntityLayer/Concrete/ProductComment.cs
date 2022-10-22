using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductComment
    {
        [Key]
        public int ProductCommentID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(250)]
        public string ProductCommentText { get; set; }

        public int ProductID { get; set; }      //Bir ürün birden fazla yorum içerir.
        public virtual Product Product{ get; set; }

        public int UserID { get; set; }      //Bir kullanıcı birden fazla yorum yapabilir.
        public virtual User User { get; set; }
    }
}
