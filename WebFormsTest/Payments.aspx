<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payments.aspx.cs" Inherits="WebFormsTest.Payments" %>

<%@ Register Assembly="JuiceUI" Namespace="Juice" TagPrefix="juice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="GridViewPanel" UpdateMode="Conditional" runat="server" >
        <ContentTemplate>
            <juice:Datepicker ID="Datepicker1" runat="server" TargetControlID="PayDateField" DateFormat="dd.mm.yy" />
            <asp:TextBox ID="PayDateField" runat="server" AutoPostBack="false" Columns="20" TextMode="DateTime"  AutoCompleteType="Disabled" EnableViewState="False" />
            <asp:Label ID="Label1" runat="server" Text="Дата платежа" />
            <br />
            
            <asp:TextBox ID="CustomerName" runat="server" AutoPostBack="false" />
            <asp:Label ID="Label2" runat="server" Text="Имя контрагента" />
            <br />

            <asp:Button ID="Filter" runat="server" Text="Отфильтровать" OnClick="FilterBtn_Click" />
            <br /><br />

            <asp:GridView ID="paymentsGrid" runat="server" 
                DataKeyNames="PaymentId" ItemType="WebFormsTest.Models.Payment"
                SelectMethod="GetPayments"
                AutoGenerateColumns="false"
                AllowPaging="True" AllowSorting="True" >
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <Columns>
                    <asp:BoundField DataField="Customer.CustomerName"
                                    HeaderText="CustomerName" 
                                    SortExpression="Customer.CustomerName" />
                    <asp:BoundField DataField="Sum" 
                                    HeaderText="Sum" 
                                    SortExpression="Sum" />
                    <asp:BoundField DataField="PaymentDate" 
                                    HeaderText="PaymentDate" 
                                    SortExpression="PaymentDate"
                                    DataFormatString="{0:dd.MM.yyyy}" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>