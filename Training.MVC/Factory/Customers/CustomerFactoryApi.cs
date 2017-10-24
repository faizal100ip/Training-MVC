using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Training.Model.Customers;

namespace Training.MVC.Factory.Customers
{
    public class CustomerFactoryApi : ICustomerFactoryApi
    {
        #region Const

        private const string _API_PATH_CUSTOMER = "/api/Customer/";
        private const string _API_RESOURCE_GetAllCustomer = "GetAllCustomer";

        #endregion

        #region Declaration

        private readonly IFactoryApi _factoryApi;
        
        #endregion

        public CustomerFactoryApi()
        {
            this._factoryApi = new FactoryApi();
        }

        public virtual IList<Customer> GetAllCustomer()
        {
            return _factoryApi.GetAPIList<Customer>(Path.Combine(_API_PATH_CUSTOMER, _API_RESOURCE_GetAllCustomer));
        }
    }
}