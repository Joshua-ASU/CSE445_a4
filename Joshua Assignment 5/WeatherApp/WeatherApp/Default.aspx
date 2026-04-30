<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WeatherApp.DefaultPage" %>

<%@ Register src="WeatherInputUserControl.ascx" tagname="WeatherInputUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="SummaryTable" runat="server" GridLines="Both" Height="58px" Width="952px">
                <asp:TableRow ID="SummaryHeader" runat="server" TableSection="TableHeader">
                    <asp:TableCell runat="server">Provider Name</asp:TableCell>
                    <asp:TableCell runat="server">Page and Component Type</asp:TableCell>
                    <asp:TableCell runat="server">Component Description</asp:TableCell>
                    <asp:TableCell runat="server">Actual resources and methods used and Location</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Joshua Lee</asp:TableCell>
                    <asp:TableCell runat="server">DLL</asp:TableCell>
                    <asp:TableCell runat="server">A converter to convert Fahrenheit into Celsius and vice versa. Input: double Output: double</asp:TableCell>
                    <asp:TableCell runat="server">C# code in DLL. User to convert data from weather web services to hte user&#39;s preference.</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Joshua Lee</asp:TableCell>
                    <asp:TableCell runat="server">User Control</asp:TableCell>
                    <asp:TableCell runat="server">A user control for entering coordinate information for the historical weather web service.</asp:TableCell>
                    <asp:TableCell runat="server">C# code behind GUI. Connected to Historical Weather Web Service.</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Joshua Lee</asp:TableCell>
                    <asp:TableCell runat="server">SVC Service</asp:TableCell>
                    <asp:TableCell runat="server">Fetches historical weather data based on date window and coordinates. Inputs: DateTime startDate, DateTime endDate, decimal latitude, decimal longitude Outputs: string WeatherData</asp:TableCell>
                    <asp:TableCell runat="server">Get historical weather data from: https://open-meteo.com       Used in the member page.</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <p>
            <asp:Label ID="TempConvHead_lbl" runat="server" Text="TempConverter:"></asp:Label>
        </p>
        <asp:Label ID="TempConvDesc_lbl" runat="server" Text="A set of two DLL functions that convert Fahrenheit into Celsius and vice versa."></asp:Label>
        <p>
            <asp:Label ID="TempConvMethod_lbl" runat="server" Text="double CtoF(double c) &amp; double FtoC(double f)"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TempConvInput_txt" runat="server">Input</asp:TextBox>
            <asp:DropDownList ID="TempConvSelect_ddl" runat="server">
                <asp:ListItem>C2F</asp:ListItem>
                <asp:ListItem>F2C</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="TempConv_btn" runat="server" OnClick="TempConv_btn_Click" Text="Invoke" />
            <asp:Label ID="TempConvOutput_lbl" runat="server" Text="Output"></asp:Label>
        </p>
        <asp:Label ID="WeatherUserControlHeader_lbl" runat="server" Text="Weather Input User Control &amp; Historical Weather Web Service TryIt: "></asp:Label>
        <uc1:WeatherInputUserControl ID="WeatherInputUserControl1" runat="server" />
    </form>
</body>
</html>
