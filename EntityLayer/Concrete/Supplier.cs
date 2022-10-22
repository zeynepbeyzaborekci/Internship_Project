using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string SupplierImage { get; set; }

        [StringLength(250)]
        public string SupplierAbout { get; set; }

        public ICollection<Product> Products { get; set; }  //Bir satıcının birden fazla ürünü olabilir.
        

    }
}
