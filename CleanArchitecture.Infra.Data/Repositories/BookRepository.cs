using CleanArchitecture.Domain.Inferfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repositories
{
   public class BookRepository :  IBookRepository 
    {
        public PrimaryDBContext _context;

        
        
       // Repository<Books> repository=new Repository<Books>();

     
        public BookRepository(PrimaryDBContext context)  
        {
            _context = context;
        }

      

        //public IQueryable<Books> Get(Expression<Func<Books, bool>> expression, Func<IQueryable<Books>, Domain.Inferfaces.IIncludableQueryable<Books, object>> include = null)
        //{
        //    IQueryable<Books> query = _context.Set<Books>().Where(expression).AsQueryable();


        //    if (include != null)
        //        query = (IQueryable<Books>) include(query);

        //    return query;
        //}


        public IQueryable<Books> Get(Expression<Func<Books, bool>> expression, params Expression<Func<Books, object>>[] includes)
        {
            var query = _context.Books.Where(expression).AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }


            return query ;
        }



        public IEnumerable<Books> GetBooks() { return _context.Books; }
    }
}
