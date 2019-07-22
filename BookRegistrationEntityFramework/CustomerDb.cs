﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEntityFramework
{
    static class CustomerDb
    {
        /// <summary>
        /// Return's all customers from the database.
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            // Create instance of DB Context
            var db = new BookRegistrationEntities();

            // Use Db context to retrieve all customers
        }
        /// <summary>
        /// Add's a customer. Return's newly added customer
        /// with the CustomerId populated.
        /// </summary>
        /// <param name="c">New Customer to be added.</param>
        /// <returns></returns>
        public static Customer AddCustomer(Customer c)
        {
            throw new NotImplementedException();
        }
    }
}