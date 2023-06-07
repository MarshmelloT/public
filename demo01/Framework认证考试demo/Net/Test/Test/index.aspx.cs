using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //如果用控健绑定就不要在用代码


                //使用代码绑定类别数据
                //List<ProjectType> typeList = ProjectTypeBLL.getTyList();

                //this.ProjectTypeShow.DataSource = typeList; // 
                //this.ProjectTypeShow.DataTextField = "Name";//显示的文本
                //this.ProjectTypeShow.DataValueField = "ID";//选中时的值
                //this.ProjectTypeShow.DataBind();



                //使用代码绑定项目数据
                //List<Bidding> biddings = BiddingBLL.getBiddingList("", 0);
                ////绑定到控件
                //this.ShowBidding.DataSource = biddings;
                //this.ShowBidding.DataBind();


            }
        }

        /// <summary>
        /// 查询的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void selectBtn_Click(object sender, EventArgs e)
        {
            //如果用控健绑定就不要在用代码

            ////获取搜索框值
            //string proName = this.ProName.Text;
            ////获取选择的类型
            //int typeId = Convert.ToInt32(this.ProjectTypeShow.SelectedValue);
            ////查询数据
            //List<Bidding> biddings = BiddingBLL.getBiddingList(proName, typeId);
            ////绑定数据到控件
            //this.ShowBidding.DataSource = biddings;
            //this.ShowBidding.DataBind();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            //重定向到添加页面
            Response.Redirect("/insertBidding.aspx");
        }
    }
}