<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script type="text/javascript" src="flashcanvas.js"></script>
    <script type="text/javascript" src="jSignature.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="signature"></div>
            <script>
                $(document).ready(function () {
                    $("#signature").jSignature()
                })
            </script>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
