﻿using CleanArchitecture.Domain.Inferfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repositories
{
   public class BookRepository : IBookRepository
    {
        public PrimaryDBContext _context;

        public BookRepository(PrimaryDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Books> GetBooks() { return _context.Books; }
    }
}
