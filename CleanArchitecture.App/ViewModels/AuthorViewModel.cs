using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.ViewModels
{
    public class AuthorViewModel
    {
        public IEnumerable<Authors> Authors { get; set; }
    }
}
