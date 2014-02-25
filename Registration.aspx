<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
    <div>
        <table>
            <tr>
                <td>Enter First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
             <tr>
                <td>Enter Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
             <tr>
                <td>Enter Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>

                 </td>
            </tr>
            
             <tr>
                <td>Enter your Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="You must Enter Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Your password doesnt match" ControlToValidate="txtConfirm" ControlToCompare="txtPassword" ></asp:CompareValidator>

            </tr>
             <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirm" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" ErrorMessage="Not the Same"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Not the Same" ControlToValidate="txtConfirm"></asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
               <td>
                   <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
               </td>
                <td>
                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                      <asp:LinkButton ID="LinkButton1" runat="server">Log in</asp:LinkButton>
                </td>
                <td></td>
            </tr>

        </table>
    
    </div>
    </form>
</body>
</html>
