using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
 

        public int AuthorsId { get; set; }

        public virtual Authors Authors { get; set; }

    }
}
