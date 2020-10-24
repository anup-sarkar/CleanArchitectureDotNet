using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Authors
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }


        public int AddressId { get; set; }

        public virtual Address  Address { get; set; }

    }
}
