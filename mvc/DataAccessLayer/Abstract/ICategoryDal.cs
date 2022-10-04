﻿using EntityLayer.concrete;
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

        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);

    }
}
