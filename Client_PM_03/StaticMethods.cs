using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_PM
{
    public static class UserMethods
    {
        public static bool Exists(this PhotoManagerClient.User u)
        {
            return u != null;
        }
    }
}
