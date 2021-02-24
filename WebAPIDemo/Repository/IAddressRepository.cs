﻿using System.Collections.Generic;
using WebAPIDemo.Entity;

namespace WebAPIDemo.Repository
{
    public interface IAddressRepository
    {
        public List<Address> LoadAll();
        public Address GetAddressById(string id);
        public bool AddAddress(Address address);
    }
}
