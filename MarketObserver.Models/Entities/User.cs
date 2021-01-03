using System;
using System.Collections.Generic;
using System.Text;

namespace MarketViewer.Models.Entities
{
    public class User
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
