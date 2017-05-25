<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RequestGrant.aspx.cs" Inherits="RequestGrant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Request Grant</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Request Grant</h1>
        <table>
            <tr>
                <td>Amount</td>
                <td>
                    <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    </td>

            </tr>
            <tr>
                <td>Explanation</td>
                <td>
                    <asp:TextBox ID="GrantExplanationBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    </td>

            </tr>
            <tr>
                <td>Type Key</td>
                <td>
                    <asp:TextBox ID="TypeKeyTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    </td>

            </tr>
             <tr>
                <td>
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
                <td>
                    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
                </td>
                <td></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
