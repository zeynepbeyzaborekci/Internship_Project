using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogCategoryManager
    {
        Repository<BlogCategory> repoblogcategory = new Repository<BlogCategory>();
        public List<BlogCategory> GetAll()
        {
            return repoblogcategory.GetAll(); //bununla bir yukardaki GetAll() aynı olmak zorunda değil. bu satırdaki Dal'den geliyor.
        }
    }
}
