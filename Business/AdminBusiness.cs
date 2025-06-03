using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using DataAccess;
using Entity;
using System.Data;


namespace Business
{
    public static class AdminBusiness
    {
        public static bool Authenticate(string adminID, string password)
        {
            string cmdText = "select * from Admins where adminID=@AdminID and password=@Password";
            string[] paramNames = { "@AdminID", "@Password" };
            object[] paramValues = { adminID, password };
            object obj = DA.ExcuteSqlCommand2(cmdText, CommandType.Text, paramNames, paramValues);
            if (obj != null)
                return true;
            else
                return false;
        }
    }
}
