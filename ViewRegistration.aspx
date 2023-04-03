<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewRegistration.aspx.cs" Inherits="IdentityFramework.ViewRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="LicensePlate" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="TRN" HeaderText="TRN" SortExpression="TRN" />
            <asp:BoundField DataField="LicensePlate" HeaderText="LicensePlate" ReadOnly="True" SortExpression="LicensePlate" />
            <asp:BoundField DataField="Chassis" HeaderText="Chassis" SortExpression="Chassis" />
            <asp:BoundField DataField="CarColour" HeaderText="CarColour" SortExpression="CarColour" />
            <asp:BoundField DataField="UpdatePeriod" HeaderText="UpdatePeriod" SortExpression="UpdatePeriod" />
            <asp:BoundField DataField="RegistrationDate" HeaderText="RegistrationDate" SortExpression="RegistrationDate" />
        </Fields>
</asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TAJConnectionString %>" SelectCommand="SELECT * FROM [RegistrationTbl]"></asp:SqlDataSource>
</asp:Content>
