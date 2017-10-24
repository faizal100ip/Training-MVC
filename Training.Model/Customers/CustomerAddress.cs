using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Training.Model.Customers
{
    public partial class CustomerAddress :  BaseEntity<int>
    {
        public int CustomerId { get; set; }

        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [StringLength(100)]
        public string AddressLine3 { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
