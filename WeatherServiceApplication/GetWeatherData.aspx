<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetWeatherData.aspx.cs" Inherits="WeatherServiceApplication.GetWeatherData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table>
    <tr>
    <td><b>Zipcode:</b></td>
    <td>
        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
        <asp:Button ID="btnGetWeather" runat="server" Text="Get Weather" 
            onclick="btnGetWeather_Click" /></td>
    </tr>
    <tr>
    <td>
        <asp:Image ID="Image1" runat="server" /></td>
    </tr>
    <tr>
     <tr>
    <td><b>City:</b></td>
    <td>
         <asp:Label ID="lblCity" runat="server"></asp:Label></td>
    </tr>
    <tr>
    <td><b>State:</b></td>
    <td>
       <asp:Label ID="lblState" runat="server"></asp:Label></td>
    </tr>
    <tr>
    <td><b>Temperature:</b></td>
    <td>
        <asp:Label ID="lblTemperature" runat="server"></asp:Label></td>
    </tr>
    <tr>
    <td><b>Wind:</b></td>
    <td>
        <asp:Label ID="lblWind" runat="server"></asp:Label></td>
    </tr>

    <tr>
    <td><b>Pressure:</b></td>
    <td>
        <asp:Label ID="lblPressure" runat="server"></asp:Label></td>
    </tr>
   
   <tr>
    <td><b>Relative Humidity:</b></td>
    <td>
        <asp:Label ID="lblHumidity" runat="server"></asp:Label></td>
    </tr>
   <tr>
    <td><b>Weather Station City:</b></td>
    <td>
        <asp:Label ID="lblWeatherStationCity" runat="server"></asp:Label></td>
    </tr>
   
   <tr>
    <td><b>Description:</b></td>
    <td>
        <asp:Label ID="lblDescription" runat="server"></asp:Label></td>
    </tr>

   
    <tr>
    <td>
        <asp:Label ID="lblError" runat="server" ForeColor=Red></asp:Label></td>
    </tr>
   
   
    </table>
    </div>
    </form>
</body>
</html>
