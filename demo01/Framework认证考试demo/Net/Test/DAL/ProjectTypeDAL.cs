using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ProjectTypeDAL
    {
        /// <summary>
        /// 获取工程
        /// </summary>
        /// <returns></returns>
        public static DataTable getTypeList()
        {
            //sql语句，链表查询所有工程信息
            string sql = "select * from ProjectType";
            //调用查询数据公共类的公共方法
            return DBHelper.GetDataTable(sql);
        }
    }
}
