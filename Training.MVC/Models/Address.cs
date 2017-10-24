using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training.MVC.Models
{
    public class Address
    {
        public Address()
        {
            Countries = new List<SelectListItem>()
            {
                new SelectListItem {Value ="0",Text="PLEASE SELECT COUNTRY", Selected=true},
                new SelectListItem {Value ="1",Text="MALAYSIA"},
                new SelectListItem {Value ="2",Text="SINGAPORE"},
                new SelectListItem {Value="3",Text="INDONESIA"}
            };
        }

        public int AddressID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressType { get; set; }

        public string Town { get; set; }
        
        public List<SelectListItem> Countries { get; private set; }

        public string CountryId { get; set; }
    }

    public enum eAddressType
    {
        PermanentAddress=0,
        MailingAddress=1,
        ShippingAddress=2
    }
}