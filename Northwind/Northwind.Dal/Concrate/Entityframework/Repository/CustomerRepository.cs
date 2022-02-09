﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrate.Entityframework.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {

        public CustomerRepository(DbContext context) : base(context)
        {

        }

        public IQueryable CustomerReport()
        {
            return dbset.AsQueryable();
        }

        public Customer GetByStringId(string customerId)
        {
            return dbset.Find(customerId);
        }
    }
}