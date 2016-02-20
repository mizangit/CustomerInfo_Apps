<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestUI.aspx.cs" Inherits="VivaTask.UI.TestUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 235px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table align="center">
        <tr>
            <td>Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Phone</td>
            <td class="auto-style1"> <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox> </td>
            <td></td>

        </tr>
        <tr>
            <td>Date of Birth</td>
            <td class="auto-style1">
                <asp:TextBox ID="dobTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Photo</td>
            <td class="auto-style1">
                <asp:FileUpload ID="photoFileUpload" runat="server" Width="228px" /></td>
            <td></td>

        </tr>
      
        <tr>
            <td></td>
            <td class="auto-style1">
                <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" Height="26px" />
&nbsp;&nbsp;
                <asp:Label ID="messLabel" runat="server"></asp:Label>
            </td>
            <td></td>

        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
