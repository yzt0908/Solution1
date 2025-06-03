using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;


namespace Business
{
    public class UserBusiness
    {
        public static bool Authenticate(string username, string password)
        {
            string cmdText = "select * from users2 where username=@UserName and password=@Password";
            string[] paramNames = { "@UserName", "@Password" };
            object[] paramValues = { username, password };
            object obj = DA.ExcuteSqlCommand2(cmdText, CommandType.Text, paramNames, paramValues);
            if (obj != null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 按userid验证用户是否存在
        /// </summary>
        public static bool Authenticate(int userid, string password)
        {
            string cmdText = "select * from users2 where userid=@UserID and password=@Password";
            string[] paramNames = { "@UserID", "@Password" };
            object[] paramValues = { userid, password };
            object obj = DA.ExcuteSqlCommand2(cmdText, CommandType.Text, paramNames, paramValues);
            if (obj != null)
                return true;
            else
                return false;
        }
        public static bool Register(UserEntity user)
        {
            // 注册新用户
            //insert into users2 values('li','123','252@qq,com','11111',2025-05-12)
            string cmdText = "insert into users2 (username,password,email,phone,createat) values (@Username,@Password,@Email,@Phone,@Createat)";
            string[] paramNames = { "@Username", "@Password", "@Email", "@Phone", "@Createat" };
            object[] paramValues = { user.UserName, user.Password, user.Email, user.Phone, user.CreateAt };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            if (n > 0)
                return true;
            else
                return false;
        }
        //修改用户信息
       //public static bool UpdateUserInfo(UserEntity user)
        //{
            //// 修改用户信息
            //string cmdText = "update users set email=@Email,phone=@Phone,updateat=@Updateat where username=@Username";
            //string[] paramNames = { "@Username", "@Email", "@Phone", "@Updateat" };
            //object[] paramValues = { user.UserName, user.Email, user.Phone, user.UpdateAt };
            //int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            //if (n > 0)
            //    return true;
            //else
            //    return false;
        //}
    }
}
