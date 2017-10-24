using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.MVC.Models
{
    public class MessageViewModel
    {
        //Constructor
        public MessageViewModel()
        {
            ErrorMessages = new List<string>();
            SuccessMessages = new List<string>();
        }

        //Properties
        public List<string> ErrorMessages { get; set; }

        public List<string> SuccessMessages { get; set; }

    }

    public enum NotifyType
    {
        Success,
        Error,
        Warning
    }
}