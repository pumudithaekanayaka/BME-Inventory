using System;

namespace BME_Inventory
{
    public static class UserRoles
    {
        private static string currentUserRole;

        public static string CurrentUserRole
        {
            get
            {
                return currentUserRole;
            }
            set
            {
                currentUserRole = value;
                // You can also save the role to a persistent storage or session if needed.
            }
        }
    }
}


