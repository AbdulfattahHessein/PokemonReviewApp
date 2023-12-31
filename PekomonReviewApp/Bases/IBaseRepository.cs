﻿using System.Linq.Expressions;

namespace PokemonReviewApp.Bases
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        bool IsExist(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> criteria, string[] includes = null);

        IQueryable<T> GetWhere(Expression<Func<T, bool>> criteria, string[] includes = null);

        bool Insert(T entity);
        public void InsertList(IEnumerable<T> entityList);
        void Update(T entity);
        public void UpdateList(IEnumerable<T> entityList);
        void Delete(T entity);
        public void DeleteList(IEnumerable<T> entityList);
        public void Attach(T entity);
        public void AttachRange(IEnumerable<T> entities);

    }
}
