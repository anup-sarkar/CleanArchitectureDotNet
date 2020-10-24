using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using CleanArchitecture.Domain.Inferfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.Services
{
    public class AddressService : IAddressService
    {
        IAddressRepository _repo;

        public AddressService(IAddressRepository addressRepository)
        {
            _repo = addressRepository;
        }
      

        public AddressViewModel GetAddresses()
        {
            return new AddressViewModel { Addresses = _repo.GetAddresses() };
        }
    }
}
