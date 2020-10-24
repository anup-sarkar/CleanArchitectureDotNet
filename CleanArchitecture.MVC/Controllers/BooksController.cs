using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.MVC.Controllers
{
    public class BooksController : Controller
    {
        private IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            BooksViewModel booksViewModel = bookService.GetBooks();

            //   var booksViewModel2 = new BooksViewModel { Books= bookService.Get(s => s.Id == 1,include: s=> (Domain.Inferfaces.IIncludableQueryable<Domain.Models.Books, object>) s.Include(x=>x.Authors)) };
                 var booksViewModel2 = new BooksViewModel { Books= bookService.Get(s => s.Id == 1,  x=>x.Authors , x=>x.Authors.Address) };

            return View(booksViewModel2);
        }
    }
}
