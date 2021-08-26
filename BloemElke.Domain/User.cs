using System;
using System.Collections.Generic;

namespace BloemElke.Domain
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
