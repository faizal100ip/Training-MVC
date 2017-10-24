using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Model.Customers;

namespace Training.MVC.Factory.Customers
{
    public interface ICustomerFactoryApi
    {
        IList<Customer> GetAllCustomer();
    }
}