using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMicroservice.Models;

namespace UserAddressMicroservice.Models
{

    //If I need navigation property I would like to use this class
    //I would change UserAddress to have reference to this class instead of user
    public class UserWithAddress: User
    {
        public UserAddress Address { get; set; }
    }
}
