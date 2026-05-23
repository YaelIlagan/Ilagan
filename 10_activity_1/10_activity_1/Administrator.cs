using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_activity_1
{
    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string password) : base(id, password)
        {
            this.admin_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }

        public void updateAdminName(string newAdminName)
        {
            admin_name = newAdminName;
        }

    }
}
