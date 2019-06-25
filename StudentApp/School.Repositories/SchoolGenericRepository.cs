using Microsoft.EntityFrameworkCore;
using School.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace School.Repositories
{
    public class SchoolGenericRepository : IGenericRepository
    {
        private readonly DbContext _context;
        public SchoolGenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Create<TModel>(TModel model) where TModel : class
        {
            _context.Set<TModel>().Add(model);
            _context.SaveChanges();
        }

        public void DeleteById<TModel>(int id) where TModel : class
        {
            var model = _context.Set<TModel>().Find(id);
            _context.Set<TModel>().Remove(model);
            _context.SaveChanges();
        }

        public TModel FindById<TModel>(int id) where TModel : class
        {
            return _context.Set<TModel>().Find(id);
        }

        public ICollection<TModel> GetAll<TModel>(Expression<Func<TModel, bool>> filter = null) where TModel : class
        {
            if(filter == null)
            {
                return _context.Set<TModel>().ToList();
            }
            else
            {
                return _context.Set<TModel>().Where(filter).ToList();
            }
        }

        public void Update<TModel>(TModel model) where TModel : class
        {
            _context.Set<TModel>().Update(model);
            _context.SaveChanges();
        }
    }
}
