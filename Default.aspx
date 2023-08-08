<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.WebForm1"  Async="true" MaintainScrollPositionOnPostback="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float: left">
        <asp:Panel ID="Panel1" runat="server">        
            <br />
            <asp:Button ID="btnGetJson" runat="server" OnClick="btnGetJson_Click" Text="Click to receive json response"  />
            <br />
            <asp:Label ID="lblHeading" runat="server" Font-Size="Large" Text="Example of using reflection to turn a json object into a c# class"></asp:Label>
            <br />
            <asp:Button ID="btnPopulateClass" runat="server" OnClick="btnPopulateClass_Click" Text="Populate RootObject" Enabled="False" />
            <br />
            <asp:Label ID="strRootObject" runat="server" Text="RootObjectValues"></asp:Label>
            <br />
                <asp:ListBox ID="lstRootObject" runat="server" Height="145px" Width="500px"></asp:ListBox>
                <br />
                <asp:Button ID="btnSensorList" runat="server" Text="ShowSensorList" OnClick="btnSensorList_Click" Enabled="False" EnableViewState="False" />
                <br />
                <asp:label ID="lblSensorList" runat="server" Text="Sensor List IDs (lsid): "></asp:label>
                <br />
             <div style="float: left">
               <asp:Button ID="btnSensorValues1" runat="server" Text="Sensor 624129 Values " Enabled="False" EnableViewState="False" OnClick="btnSensorValues1_Click"></asp:Button>
                <br />
                <asp:ListBox ID="lstSensor1" runat="server" Height="204px" Width="197px"></asp:ListBox>
                <br />
                <asp:Button ID="btnSensorValues2" runat="server" Text="Sensor 624144 values " Enabled="False" OnClick="btnSensorValues2_Click"></asp:Button>
                <br />
                <asp:ListBox ID="lstSensor2" runat="server" Height="187px" Width="195px"></asp:ListBox>
                <br />           
             </div>
             <div style="float: left">
                <asp:Button ID="btnSensorValues3" runat="server" Text="Sensor 624131 Values " Enabled="False" OnClick="btnSensorValues3_Click"></asp:Button>
                <br />
                <asp:ListBox ID="lstSensor3" runat="server" Height="206px" Width="201px"></asp:ListBox>
                <br />
                <asp:Button ID="btnSensorValues4" runat="server" Text="Sensor 624130 Values " Enabled="False" OnClick="btnSensorValues4_Click"></asp:Button>
                <br />
                <asp:ListBox ID="lstSensor4" runat="server" Height="187px" Width="202px"></asp:ListBox>
              </div>
        </asp:Panel>
        </div>
        <div style="float: left">
        <asp:Panel ID="Panel2" runat="server">
            <asp:TextBox ID="txtJson" runat="server" Height="111px" TextMode="MultiLine" Width="491px"></asp:TextBox>
            <br />
            <asp:Label ID="lblDynamic" runat="server" Text="Example of retrieving all sensor values using dynamic jsonObj"></asp:Label>
            <br />
            <asp:Button ID="btnSensorValues" runat="server" OnClick="btnSensorValues_Click" Text="Cllick here to display sensor values using dynamic json obj" Enabled="False" />
            <br />
            <asp:Label ID="lblSelectedValue" runat="server" Text="Selected Value"></asp:Label>
            <br />
            <asp:ListBox ID="lstAllSensorValues" runat="server" Height="553px" Width="514px" AutoPostBack="True"></asp:ListBox>
        </asp:Panel>
        </div>
    </form>
</body>
</html>
