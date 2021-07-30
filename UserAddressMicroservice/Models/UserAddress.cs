using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMicroservice.Models;

namespace UserAddressMicroservice.Models
{
    public class UserAddress
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
