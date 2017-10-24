using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Training.Model.Customers
{
    public partial class Customer: BaseEntity<int>
    {
        private ICollection<CustomerAddress> _customerAddress;

        public Customer()
        {

        }
        
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        #region Navigation Properties
        public virtual ICollection<CustomerAddress> CustomerAddresses
        {
            get { return _customerAddress ?? (_customerAddress = new List<CustomerAddress>()); }
            protected set { _customerAddress = value; }
        }
        #endregion
    }
}
