using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 项目工程业务逻辑
    /// </summary>
    public class BiddingBLL
    {
        /// <summary>
        /// 获取全部工程项目列表
        /// </summary>
        /// <returns></returns>
        public static List<Bidding> getBiddingList(string proName = "", int ProTypeID = 0)
        {
            //int typeId = Convert.ToInt32(typeId);
            //调用查询工程项目的数据访问层方法，并用data变量接收
            DataTable data = BiddingDAL.getBiddingList(proName, ProTypeID);
            //等下用于存储工程项目列表
            List<Bidding> biddingList = new List<Bidding>();
            //判断是否大于0
            if (data.Rows.Count > 0)
            {
                //循环出datatable中的所有数据列(Rows)取出每一列的内容
                foreach (DataRow item in data.Rows)
                {
                    //实例化一列工程项目
                    Bidding bidding = new Bidding()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        ProTypeID = Convert.ToInt32(item["ProTypeID"]),
                        ProName = item["ProName"].ToString(),
                        ProTypeName = item["ProTypeName"].ToString(),
                        ProAddress = item["ProAddress"].ToString(),
                        Input = item["Input"].ToString(),
                        Date = DateTime.Parse(item["Date"].ToString()),
                        Charge = item["Charge"].ToString(),
                        Unit = item["Unit"].ToString(),
                        Amount = Convert.ToDecimal(item["Amount"]),
                        Contacts = item["Contacts"].ToString(),
                        Tel = item["Tel"].ToString(),
                    };
                    //把工程项目添加到工程项目列表里，等下进行返回
                    biddingList.Add(bidding);
                }
            }

            return biddingList;
        }

        /// <summary>
        /// 根据id删除工程项目
        /// </summary>
        /// <param name="bidding">一个工程项目（实体）</param>
        /// <returns></returns>
        public static object delBidding(Bidding bidding)
        {
            //如果id小于0意味着取到的id不正确，因为数据库中id不可能为0，为0会导致语句报错
            if (bidding.ID <= 0)
            {
                //直接返回提示
                return new
                {
                    msg = "id不正确",
                };
            }
            //否则调用数据访问层（DAL）的删除工程项目方法
            return BiddingDAL.delBidding(bidding);
        } 

        /// <summary>
        /// 添加工程项目
        /// </summary>
        /// <param name="bidding">一个工程项目（实体）</param>
        /// <returns></returns>
        public static int insertBidding(Bidding bidding)
        {
            //非空判断
            if (bidding.ProName == "")
            {
                return 0;
            }
            //判断类别是否选上
            if (bidding.ProTypeID <= 0)
            {
                return 0;
            }
            //其余的省略了，因为页面用了验证控件
            
            //返回受影响的行数
            return BiddingDAL.insertBidding(bidding);
            
        }
    }
}
