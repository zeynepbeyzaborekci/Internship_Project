using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogCategory
    {
        [Key]
        public int BlogCategoryID { get; set; }

        [StringLength(50)]
        public string BlogCategoryName { get; set; }
        
        public ICollection<Blog> Blogs { get; set; }     //Bir kategori birden fazla blog içerebilir.

       // public int BlogerID { get; set; }         //Bir bloger birden fazla kategoride yazı yazabilir. 
        //public virtual Bloger Bloger { get; set; }
    }
}
