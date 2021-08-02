﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // generic constraint
    // class : sadece class değil tüm referans tipler anlamında
    //IEntity : IEntity olabilir yada onu implemente eden bir nesne olabili
    // new : new'lenebiliyor olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
