using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100)]
        public string ProductImage { get; set; }
        public DateTime ProductDate { get; set; }
        public string ProductContent { get; set; }


        public int ProductCategoryID { get; set; }      //Bir kategori birden fazla ürün içerebilir.
        public virtual ProductCategory ProductCategory { get; set; }

        public int SupplierID { get; set; }             // Bir ürün bir satıcı tarafından satılır ve bir satıcının birden fazla ürünü olabilir.
        public virtual Supplier Supplier { get; set; }

        public ICollection<ProductComment> ProductComments { get; set; }   //Bir ürüne birden fazla yorum yapılabilir.

    }
}
