using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Class
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public UserRole UserRole { get; set; }

        public UserInfo()
        {
            UserRole = UserRole;
        }
    }

    public enum UserRole
    {
        Full = 1,
        Create = 2,
        Read = 3
    }
}
