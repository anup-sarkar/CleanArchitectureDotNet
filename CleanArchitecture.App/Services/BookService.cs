using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using CleanArchitecture.Domain.Inferfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.App.Services
{
    public class BookService : IBookService
    {

        
        public IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IQueryable<Books> Get(Expression<Func<Books, bool>> expression, params Expression<Func<Books, object>>[] includes)
        {
            return   _bookRepository.Get(expression,includes) ;
        }

    

        public BooksViewModel GetBooks()
        {
            return new BooksViewModel { Books = _bookRepository.GetBooks() };
        }


    }
}
