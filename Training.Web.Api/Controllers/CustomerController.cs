using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Training.Model.Customers;
using Training.Services.Customers;

namespace Training.Web.Api.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        #region Declaration

        private readonly ICustomerService _customerService;

        #endregion

        #region Ctor

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        #endregion

        #region Method: Customer
        [Route("GetAllCustomer")]
        [HttpGet]
        public IList<Customer> GetAllCustomer()
        {
            return _customerService.GetAllCustomer();
        }
        #endregion

        #region Method: CustomerAddress

        #endregion

    }
}
