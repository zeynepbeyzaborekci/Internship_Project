using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }
        
        [StringLength(50)]
        public string ProductCategoryName { get; set; }

        public ICollection<Product> Products { get; set; }     //Bir kategori birden fazla ürün içerebilir.

        
    }
}
