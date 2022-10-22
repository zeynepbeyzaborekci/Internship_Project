using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [StringLength(100)]
        public string BlogTitle { get; set; }

        [StringLength(100)]
        public string BlogImage { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogContent { get; set; }
        
        public int BlogCategoryID { get; set; }      //Bir kategori birden fazla blog içerebilir.
        public virtual BlogCategory BlogCategory { get; set; }

        public int BlogerID { get; set; }             // Bir blog bir bloger tarafından yazılır ve bir blogerın birden fazla bloğu olabilir.
        public virtual Bloger Bloger { get; set; }

        public ICollection<BlogComment> BlogComments { get; set; }   //Bir blog birden fazla yorum içerir.
    } 
}
