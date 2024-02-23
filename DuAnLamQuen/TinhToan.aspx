﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhToan.aspx.cs" Inherits="DuAnLamQuen.TinhToan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Data/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="">
            <asp:Label ID="Label1" runat="server" Text="Tính toán đơn giản"></asp:Label>
            <br/>
            Nhập số 1 <asp:TextBox ID="txtSo1" runat="server"></asp:TextBox>
            <br/>
            Nhập số 2 <asp:TextBox ID="txtSo2" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="btnCong" runat="server" Text="Cộng" OnClick="btnCong_Click" />
            <asp:Button ID="btnTru" runat="server" Text="Trừ" OnClick="btnTru_Click" />
            <asp:Button ID="btnNhan" runat="server" Text="Nhân" OnClick="btnNhan_Click" />
            <asp:Button ID="btnChia" runat="server" Text="Chia" OnClick="btnChia_Click" />
            <br/>
            Kết quả <asp:TextBox ID="txtKetQua" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
