<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SCalc1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <table>  
        <tr>  
            <td colspan="4">  
                 </td>  
        </tr>  
        <tr>  
            <td colspan="4">  
                <asp:TextBox ID="TextBox1" runat="server" Height="45px" Width="375px"   
                    TextMode="MultiLine" Font-Bold="True" Font-Size="X-Large" ReadOnly="True"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td colspan="4" height="30px">  
                &nbsp;</td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Button ID="Button1" runat="server" Height="50px" Text="1"   
                    Width="95px" onclick="Button1_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button2" runat="server" Height="50px" Text="2"   
                    Width="95px" onclick="Button2_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button3" runat="server" Height="50px" Text="3"   
                    Width="95px" onclick="Button3_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button4" runat="server" Height="50px" Text="+"   
                    Width="95px" onclick="Button4_Click" />  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Button ID="Button5" runat="server" Height="50px" Text="4"   
                    Width="95px" onclick="Button5_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button6" runat="server" Height="50px" Text="5"   
                    Width="95px" onclick="Button6_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button7" runat="server" Height="50px" Text="6"   
                    Width="95px" onclick="Button7_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button8" runat="server" Height="50px" Text="-"   
                    Width="95px"  ForeColor="Black"   
                    onclick="Button8_Click" />  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Button ID="Button9" runat="server" Height="50px" Text="7"   
                    Width="95px" onclick="Button9_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button10" runat="server" Height="50px" Text="8"   
                    Width="95px" onclick="Button10_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button11" runat="server" Height="50px" Text="9"   
                    Width="95px" onclick="Button11_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button12" runat="server" Height="50px" Text="X"   
                    Width="95px"  onclick="Button12_Click" />  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Button ID="Button13" runat="server" Height="50px" Text="0"   
                    Width="95px" onclick="Button13_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button14" runat="server" Height="50px" Text="clear"   
                    Width="95px" onclick="Button14_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button15" runat="server" Height="50px" Text="/"   
                    Width="95px" ClientIDMode="AutoID" onclick="Button15_Click" />  
            </td>  
            <td>  
                <asp:Button ID="Button16" runat="server" Height="50px" Text="="   
                    Width="95px"  onclick="Button16_Click" />  
            </td>  
        </tr>  
        
</asp:Content>
