using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DA
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DA()
        {
            con = new SqlConnection(@"server=LAPTOP-DG3DVT7K;database=shoesshop;trusted_connection=true;");
            cmd = new SqlCommand();
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
        }
        /// <summary>
        /// 执行包含参数的存储过程或sql语句的增删改命令，返回受影响行数。
        /// </summary>
        /// <param name="cmdText">命令文本（存储过程名或sql语句）</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="paramNames">参数名数组</param>
        /// <param name="paramValues">参数值数组</param>
        /// <returns></returns>
        public static int ExcuteSqlCommand(string cmdText, CommandType cmdType, string[] paramNames, object[] paramValues)
        {
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            if (paramNames != null)
            {
                cmd.Parameters.Clear();
                for (int i = 0; i < paramNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], paramValues[i]);
                }
            }
            if (con.State != ConnectionState.Open)
                con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n;
        }

        /// <summary>
        /// 执行包含参数的存储过程或sql语句的查询命令，返回单一数据。
        /// </summary>
        /// <param name="cmdText">命令文本（存储过程名或sql语句）</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="paramNames">参数名数组</param>
        /// <param name="paramValues">参数值数组</param>
        /// <returns></returns>
        public static object ExcuteSqlCommand2(string cmdText, CommandType cmdType, string[] paramNames, object[] paramValues)
        {
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            if (paramNames != null)
            {
                cmd.Parameters.Clear();
                for (int i = 0; i < paramNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], paramValues[i]);
                }
            }
            if (con.State != ConnectionState.Open)
                con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        /// <summary>
        /// 执行包含参数的存储过程或者sql语句的查询命令，返回结果集。
        /// </summary>
        /// <param name="cmdText">命令文本（存储过程名或sql语句）</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="paramNames">参数名数组</param>
        /// <param name="paramValues">参数值数组</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string cmdText, CommandType cmdType, string[] paramNames, object[] paramValues)
        {
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            if (paramNames != null)
            {
                cmd.Parameters.Clear();
                for (int i = 0; i < paramNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], paramValues[i]);
                }
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
