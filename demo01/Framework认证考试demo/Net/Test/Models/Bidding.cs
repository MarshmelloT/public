using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 投标管理信息实体类
    /// </summary>
    public class Bidding
    {
        /// <summary>
        /// 项目id
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProName { get; set; }
        /// <summary>
        /// 项目类型id
        /// </summary>
        public int ProTypeID { get; set; }
        /// <summary>
        /// 项目类型名
        /// </summary>
        public string ProTypeName { get; set; }
        /// <summary>
        /// 项目地址
        /// </summary>
        public string ProAddress { get; set; }
        /// <summary>
        /// 录入人
        /// </summary>
        public string Input { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 投标负责人
        /// </summary>
        public string Charge { get; set; }
        /// <summary>
        /// 建设单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 预计合同金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contacts { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }
    }
}
