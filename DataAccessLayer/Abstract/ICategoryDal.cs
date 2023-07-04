using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal : IRepository<Category>
    {
        //crud
        //type name();
        List<Category> List();

        new void Insert(Category p);
        new void Update(Category p);
        new void Delete(Category p);

    }
}
