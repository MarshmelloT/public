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
    /// 分类业务逻辑层
    /// </summary>
    public class ProjectTypeBLL
    {
        /// <summary>
        /// 获取工程分类
        /// </summary>
        /// <returns></returns>
        public static List<ProjectType> getTyList()
        {
            //调用查询工程项目的数据访问层方法，并用data变量接收
            DataTable data = ProjectTypeDAL.getTypeList();
            //等下用于存储工程项目列表
            List<ProjectType> typeList = new List<ProjectType>();
            //先添加一个请选择
            typeList.Add(new ProjectType()
            {
                ID = 0,
                Name = "--请选择--"
            });
            //
            //判断是否大于0
            if (data.Rows.Count > 0)
            {
                //循环出datatable中的所有数据列(Rows)取出每一列的内容
                foreach (DataRow item in data.Rows)
                {
                    //实例化一列工程项目
                    ProjectType projectType = new ProjectType()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        Name = item["Name"].ToString(),                        
                    };
                    //把工程项目添加到工程项目列表里，等下进行返回
                    typeList.Add(projectType);
                }
            }
            return typeList;
        }
    }
}
