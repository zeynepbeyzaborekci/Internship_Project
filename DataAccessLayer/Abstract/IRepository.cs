﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        int Insert(T parameter);
        int Update(T parameter);
        int Delete(T parameter);
        T GetById(int id);
    }
}
