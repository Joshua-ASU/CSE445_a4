<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WeatherInputUserControl.ascx.cs" Inherits="WeatherApp.WebUserControl1" %>
<p>
    <asp:Label ID="Lat_lbl" runat="server" Text="Latitude: "></asp:Label>
    <asp:TextBox ID="Lat_txt" runat="server" Height="16px">10</asp:TextBox>
</p>
<p>
    <asp:Label ID="Long_lbl" runat="server" Text="Longitude: "></asp:Label>
    <asp:TextBox ID="Long_txt" runat="server">100</asp:TextBox>
</p>
<asp:Calendar ID="Start_clndr" runat="server" SelectedDate="2025-01-01" VisibleDate="2025-01-01"></asp:Calendar>
<asp:Calendar ID="End_clndr" runat="server" SelectedDate="2026-01-01" VisibleDate="2026-01-01"></asp:Calendar>

<asp:Button ID="Weather_btn" runat="server" OnClick="Weather_btn_Click" Text="Get Data" />
<asp:Label ID="Result_lbl" runat="server" Text="Results outputs here"></asp:Label>


