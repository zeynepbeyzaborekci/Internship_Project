using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bloger
    {
        [Key]
        public int BlogerID { get; set; }

        [StringLength(50)]
        public string BlogerName { get; set; }

        [StringLength(100)]
        public string BlogerImage { get; set; }

        [StringLength(250)]
        public string BlogerAbout { get; set; }

        public ICollection<Blog> Blogs { get; set; }  //Bir blogerın birden fazla bloğu olabilir.
        //public ICollection<BlogCategory> BlogCategories { get; set; }  //Bir bloger birden fazla kategoride yazı yazabilir. 
    }
}
