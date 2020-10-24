using CleanArchitecture.App.ViewModels;
using CleanArchitecture.Domain.Inferfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.App.Interfaces
{
    public interface IBookService
    {
        BooksViewModel GetBooks();

        public IQueryable<Books> Get(Expression<Func<Books, bool>> expression, params Expression<Func<Books, object>>[] includes);

    }
}
