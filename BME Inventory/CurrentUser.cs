using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BME_Inventory
{
    public static class CurrentUser
    {
        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
    }

}
