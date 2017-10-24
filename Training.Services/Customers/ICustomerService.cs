using System;
using System.Collections.Generic;
using Training.Model.Customers;

namespace Training.Services.Customers
{
    public interface ICustomerService
    {
        #region Customer

        IList<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        void InsertCustomer(Customer model);
        void UpdateCustomer(Customer model);
        void DeleteCustomer(Customer model);

        #endregion

        #region CustomerAddress
        IList<CustomerAddress> GetAllCustomerAddress();
        CustomerAddress GetCustomerAddressById(int id);
        void InsertCustomerAddress(CustomerAddress model);
        void UpdateCustomerAddress(CustomerAddress model);
        void DeleteCustomerAddress(CustomerAddress model);

        #endregion
    }
}
