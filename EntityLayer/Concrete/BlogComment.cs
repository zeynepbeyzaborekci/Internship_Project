using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogComment
    {
        [Key]
        public int BlogCommentID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }
        
        [StringLength(250)]
        public string BlogCommentText { get; set; }

        public int BlogID { get; set; }      //Bir blog birden fazla yorum içerir.
        public virtual Blog Blog { get; set; }
        
        public int UserID { get; set; }      //Bir kullanıcı birden fazla yorum yapabilir.
        public virtual User User { get; set; }


    }
}
