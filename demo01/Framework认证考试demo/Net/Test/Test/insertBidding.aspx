<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertBidding.aspx.cs" Inherits="Test.insertBidding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>*项目名：</td>
                    <td>
                        <asp:TextBox ID="ProName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="White" ControlToValidate="ProName" ErrorMessage="必填项" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>*项目类型：</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="必选" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>项目地址：</td>
                    <td>
                        <asp:TextBox ID="ProAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>录入人：</td>
                    <td>
                        <asp:TextBox ID="Input" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>*日期：</td>
                    <td>
                        <asp:TextBox ID="Date" runat="server" TextMode="DateTime" Placeholder="如：2012-12-12"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="请输入日期格式" ForeColor="Red" ControlToValidate="Date"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>*投标负责人：</td>
                    <td>
                        <asp:TextBox ID="Charge" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Charge" ErrorMessage="必填" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>建设单位：</td>
                    <td>
                        <asp:TextBox ID="Unit" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>*合同预计金额：</td>
                    <td>
                        <asp:TextBox ID="Amount" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Amount" ErrorMessage="必填" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>联系人：</td>
                    <td>
                        <asp:TextBox ID="Contacts" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>联系电话：</td>
                    <td>
                        <asp:TextBox ID="Tel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="insertBtn" runat="server" Text="添加" OnClick="insertBtn_Click" />
                    </td>
                </tr>
            </table>

            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/index.aspx">返回列表</asp:LinkButton>
        </div>
    </form>
</body>
</html>
