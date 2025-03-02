﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampı_301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void İnsert(T entity);

        void Update(T entity);

        void Delete(int id);

        List<T> GetAll();

        T GetById(int id);
    }
}
