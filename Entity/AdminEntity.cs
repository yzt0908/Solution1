using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AdminEntity
    {
        string adminID;
        string password;

        public string AdminID { get => adminID; set => adminID = value; }
        public string Password { get => password; set => password = value; }
    }
}
