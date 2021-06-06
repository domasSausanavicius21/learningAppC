﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExamples.Repository
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
