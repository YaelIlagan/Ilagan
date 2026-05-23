using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_activity_1
{
    public class User
    {

        private string user_id;
        protected string user_password;

        public User(string id, string password)
        {
            this.user_id = id;
            this.user_password = password;
        }

        public bool verifyLogin(string id, string pass)
        {
            return user_id.Equals(id) && user_password.Equals(pass);
        }

        public virtual void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }
    }
}
