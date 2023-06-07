using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 数据交互公共类，里面封装数据库交互的公共方法
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 数据库链接
        /// </summary>
        public static string connStr = "Data Source=.;Initial Catalog=Test;Integrated Security=True";

        /// <summary>
        /// 查询共方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, params SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            //添加查询条件
            dap.SelectCommand.Parameters.AddRange(param);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            //定义内存数据表存放数据
            DataTable data = new DataTable();
            dap.Fill(data);//绘制查询到的数据进行报错

            dap.SelectCommand.Parameters.Clear();//清空参数
            conn.Close();//关闭数据库链接
            conn.Dispose();//释放资源

            return data;
        }

        /// <summary>
        /// 增删改公告方法
        /// </summary>
        /// <param name="sql">数据访问层传递的sql语句</param>
        /// <param name="param">数据访问层传递的参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(param);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();//打开数据库链接
            }
            //提交增删改并返回受影响行数，用变量count记录
            int count = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();//清空参数
            conn.Close();//关闭数据库链接
            conn.Dispose();//释放资源

            //返回受影响的行数
            return count;
        }
    }
}
