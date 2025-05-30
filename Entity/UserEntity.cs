using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserEntity
    {
        string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        DateTime createAt;

        public DateTime CreateAt
        {
            get { return createAt; }
            set { createAt = value; }
        }



    }
}
