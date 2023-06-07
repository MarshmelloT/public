<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Test.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            项目名称：<asp:TextBox ID="ProName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; 
            项目类型：
            <asp:DropDownList ID="ProjectTypeShow" runat="server" DataSourceID="ProjectTypeServer" DataTextField="Name" DataValueField="ID">
                <asp:ListItem>--请选择--</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="selectBtn" runat="server" Text="查询" OnClick="selectBtn_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="insertBtn" runat="server" Text="添加" OnClick="insertBtn_Click" />
            <br />
            <asp:GridView ID="ShowBidding" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="144px" Width="712px" AutoGenerateColumns="False" DataSourceID="ProListServer" DataKeyNames="ID,ProName,ProTypeID,ProTypeName,ProAddress,Input,Date,Charge,Unit,Amount,Contacts,Tel">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="ProName" HeaderText="ProName" SortExpression="ProName" />
                    <asp:BoundField DataField="ProTypeID" HeaderText="ProTypeID" SortExpression="ProTypeID" />
                    <asp:BoundField DataField="ProTypeName" HeaderText="ProTypeName" SortExpression="ProTypeName" />
                    <asp:BoundField DataField="ProAddress" HeaderText="ProAddress" SortExpression="ProAddress" />
                    <asp:BoundField DataField="Input" HeaderText="Input" SortExpression="Input" />
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                    <asp:BoundField DataField="Charge" HeaderText="Charge" SortExpression="Charge" />
                    <asp:BoundField DataField="Unit" HeaderText="Unit" SortExpression="Unit" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="Contacts" HeaderText="Contacts" SortExpression="Contacts" />
                    <asp:BoundField DataField="Tel" HeaderText="Tel" SortExpression="Tel" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" CommandName="delete" OnClientClick="return confirm(&quot;您确定要删除吗？&quot;)" Text="删除" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <asp:ObjectDataSource ID="ProjectTypeServer" runat="server" SelectMethod="getTyList" TypeName="BLL.ProjectTypeBLL">
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ProListServer" runat="server" DataObjectTypeName="Models.Bidding" DeleteMethod="delBidding" SelectMethod="getBiddingList" TypeName="BLL.BiddingBLL">
            <SelectParameters>
                <asp:ControlParameter ControlID="ProName" Name="proName" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="ProjectTypeShow" Name="ProTypeID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
