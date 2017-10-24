using System.ComponentModel.DataAnnotations;

namespace Training.MVC.Models
{
    public class Person
    {
        public Person()
        {
            PermanentAddresses = new Address();
            MailingAddresses = new Address();
        }

        [Required(ErrorMessage ="First Name Required")]
        [StringLength(100)]
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [StringLength(100,MinimumLength =10,ErrorMessage ="Sila isi la" )]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage ="Email Required")]
        public string Email { get; set; }


        public Address PermanentAddresses { get; set; }

        public Address MailingAddresses { get; set; }

        public Address ShippingAddresses { get; set; }
    }
}