using System;
using System.Collections.Generic;
using System.Linq;
using Training.Data;
using Training.Model.Customers;

namespace Training.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        #region Declaration

        private readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<CustomerAddress> _customerAddressRepository;

        #endregion

        #region Ctor

        public CustomerService(IRepository<Customer> customerRepository, IRepository<CustomerAddress> customerAddressRepository)
        {
            this._customerRepository = customerRepository;
            this._customerAddressRepository = customerAddressRepository;
        }

        #endregion

        #region Method: Customer
        
        public IList<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAll().ToList();
        }
        
        public Customer GetCustomerById(int id)
        {
            if (id == 0)
                return null;
            return _customerRepository.GetById(id);
        }

        public void InsertCustomer(Customer model)
        {
            if (model == null)
                throw new ArgumentNullException("category");

            _customerRepository.Insert(model);
        }

        public void UpdateCustomer(Customer model)
        {
            if (model == null)

                throw new ArgumentNullException("category");
            _customerRepository.Update(model);
        }
        public void DeleteCustomer(Customer model)
        {
            if (model == null)
                throw new ArgumentNullException("category");

            _customerRepository.Delete(model);
        }

        #endregion

        #region CustomerAddress

        public CustomerAddress GetCustomerAddressById(int id)
        {
            if (id == 0)
                return null;

            return _customerAddressRepository.GetById(id);
        }

        public IList<CustomerAddress> GetAllCustomerAddress()
        {
            return _customerAddressRepository.GetAll().ToList();
        }

        public void UpdateCustomerAddress(CustomerAddress model)
        {
            if (model == null)
                throw new ArgumentNullException("category");

            _customerAddressRepository.Update(model);
        }

        public void InsertCustomerAddress(CustomerAddress model)
        {
            if (model == null)
                throw new ArgumentNullException("category");

            _customerAddressRepository.Insert(model);
        }
        public void DeleteCustomerAddress(CustomerAddress model)
        {
            if (model == null)
                throw new ArgumentNullException("category");

            _customerAddressRepository.Delete(model);
        }

        #endregion

    }
}
