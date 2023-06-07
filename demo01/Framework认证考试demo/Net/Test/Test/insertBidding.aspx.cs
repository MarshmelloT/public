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
    public partial class insertBidding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //使用代码绑定项目类别数据
                List<ProjectType> typeList = ProjectTypeBLL.getTyList();

                this.DropDownList1.DataSource = typeList; // 
                this.DropDownList1.DataTextField = "Name";//显示的文本
                this.DropDownList1.DataValueField = "ID";//选中时的值
                this.DropDownList1.DataBind();

            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void insertBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //实例化添加对象
                Bidding bidding = new Bidding()
                {
                    ProName = this.ProName.Text,
                    ProTypeID = Convert.ToInt32(this.DropDownList1.SelectedValue),
                    ProAddress = this.ProAddress.Text,
                    Input = this.Input.Text,
                    Date = Convert.ToDateTime(this.Date.Text),
                    Charge = this.Charge.Text,
                    Unit = this.Unit.Text,
                    Amount = Convert.ToDecimal(this.Amount.Text),
                    Contacts = this.Contacts.Text,
                    Tel = this.Tel.Text
                };
                //当类型小于0说明没选类型直接返回
                if (bidding.ProTypeID <= 0)
                {
                    Response.Write("<script>alert('分类ID不能小于等于0！');</script>");
                    return;
                }

                //判断受影响的行数
                if (BiddingBLL.insertBidding(bidding) <= 0)
                {
                    Response.Write("<script>alert('添加失败！');</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加成功！');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('还没填完必填项！');</script>");
            }

        }
    }
}