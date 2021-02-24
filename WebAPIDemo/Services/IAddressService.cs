﻿using System.Collections.Generic;
using DataLayer.Entity;

namespace APIDemo.Services
{
    public interface IAddressService
    {
        public List<Address> LoadAll();
        public Address GetAddressById(string id);
        public bool AddAddress(Address address);
    }
}