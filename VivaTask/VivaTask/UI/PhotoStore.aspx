<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoStore.aspx.cs" Inherits="VivaTask.UI.PhotoStore" %>

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
            <td>Photo</td>
            <td class="auto-style1">
                <asp:FileUpload ID="photoFileUpload" runat="server" Width="228px" /></td>
            <td></td>

        </tr>
      
        <tr>
            <td></td>
            <td class="auto-style1">
                <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
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
