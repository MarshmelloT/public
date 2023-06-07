using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BiddingDAL
    {
        /// <summary>
        /// 获取工程
        /// </summary>
        /// <returns></returns>
        public static DataTable getBiddingList(string proName = "", int typeId = 0)
        {
            //sql语句，链表查询所有工程信息
            string sql = "select b.*,p.[Name] as ProTypeName,p.ID as ProTypeID from Bidding as b left join ProjectType as p on b.ProTypeID=p.ID " +
                " where b.ProName like @param";

            //参数换成List列表
            List<SqlParameter> param = new List<SqlParameter>();
            //默认模糊查询工程名
            proName = "%" + proName + "%";
            param.Add(new SqlParameter("@param", proName));

            //如果选择了类型就把类型拼接进去
            if (typeId > 0)
            {
                sql += " and b.ProTypeID=@ProTypeID";
                //配置参数
                param.Add(new SqlParameter("@ProTypeID", typeId));
            }

            //调用查询数据公共类的公共方法
            //注意转换参数为Array数组型
            return DBHelper.GetDataTable(sql, param.ToArray());
        }

        /// <summary>
        /// 添加工程
        /// </summary>
        /// <param name="bidding"></param>
        /// <returns></returns>
        public static int insertBidding(Bidding bidding)
        {
            //新增商品sql
            string sql = "insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)" +
                         " values(@ProName,@ProTypeID,@ProAddress,@Input,@Date,@Charge,@Unit,@Amount,@Contacts,@Tel)";
            //配置参数
            SqlParameter[] param =
            {
                new SqlParameter("@ProName",bidding.ProName),
                new SqlParameter("@ProTypeID",bidding.ProTypeID),
                new SqlParameter("@ProAddress",bidding.ProAddress),
                new SqlParameter("@Input",bidding.Input),
                new SqlParameter("@Date",bidding.Date),
                new SqlParameter("@Charge",bidding.Charge),
                new SqlParameter("@Unit",bidding.Unit),
                new SqlParameter("@Amount",bidding.Amount),
                new SqlParameter("@Contacts",bidding.Contacts),
                new SqlParameter("@Tel",bidding.Tel)
            };
            //调用增删改数据公共类的公共方法
            return DBHelper.ExecuteNonQuery(sql, param);
        }

        /// <summary>
        /// 根据id删除商品
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public static int delBidding(Bidding bidding)
        {
            string sql = "delete Bidding where ID=@ID";
            //配置参数
            SqlParameter[] param =
            {
                new SqlParameter("@ID",bidding.ID)
            };
            //调用增删改数据公共类的公共方法
            return DBHelper.ExecuteNonQuery(sql, param);
        }


    }
}
