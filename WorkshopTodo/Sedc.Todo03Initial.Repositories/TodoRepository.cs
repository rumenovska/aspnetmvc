using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Sedc.Todo03Initial.Entities;
using Sedc.Todo03Initial.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Sedc.Todo03Initial.Repositories
{
    public class TodoRepository: IGenericRepository
    {
        private readonly TodoContext _context;
        public TodoRepository(TodoContext context)
        {
            _context = context;
        }
        public ICollection<TModel> GetAll<TModel>(Expression<Func<TModel, bool>> filter = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null) where TModel : BaseEntity
        {
            if (filter == null)
            {
                return _context.Set<TModel>().ToList();
            }
            else
            {
                return _context.Set<TModel>().Where(filter).ToList();
            }
        }

        public TModel FindById<TModel>(int id, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null) where TModel : BaseEntity
        {
            return _context.Set<TModel>().Find(id);
        }

        public void Create<TModel>(TModel model) where TModel : BaseEntity
        {
            _context.Set<TModel>().Add(model);
            _context.SaveChanges();
        }

        public void Update<TModel>(TModel model) where TModel : BaseEntity
        {
            _context.Set<TModel>().Update(model);
            _context.SaveChanges();
        }

        public void DeleteById<TModel>(int id) where TModel : BaseEntity
        {
            var model = _context.Set<TModel>().Find(id);
            _context.Set<TModel>().Remove(model);
            _context.SaveChanges();
        }
    }
}
