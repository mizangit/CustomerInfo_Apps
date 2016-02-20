<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="VivaTask.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.2.0.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function()
        {
            $('#dobTextBox').datepicker( );
        })

        

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr>
            <td>Country</td>
            <td>
                <asp:DropDownList ID="countryDropDownList" runat="server"></asp:DropDownList></td>
            <td></td>

        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
          <tr>
            <td>Salary</td>
            <td>
                <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Phone</td>
            <td> <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox> </td>
            <td></td>

        </tr>
        <tr>
            <td>Fax</td>
            <td>
                <asp:TextBox ID="faxTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Web Url</td>
            <td>
                <asp:TextBox ID="urlTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Date of Birth</td>
            <td>
                <asp:TextBox ID="dobTextBox" runat="server"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>Photo</td>
            <td>
                <asp:FileUpload ID="photoFileUpload" runat="server" /></td>
            <td></td>

        </tr>
      
        <tr>
            <td></td>
            <td></td>
            <td></td>

        </tr>
    </table>
    </div>
    </form>
</body>
</html>
