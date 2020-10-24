using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using CleanArchitecture.Domain.Inferfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.Services
{
    public class AuthorService : IAuthorService
    {

        public IAuthorRepository _repo;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _repo = authorRepository;
        }

        public AuthorViewModel GetAuthors()
        {
            return new AuthorViewModel { Authors = _repo.GetAuthors() };
        }
    }
}
