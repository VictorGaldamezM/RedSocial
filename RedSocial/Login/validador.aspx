<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validador.aspx.cs" Inherits="ProyectoFinalInventario2022.Login.validador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
	<link rel="stylesheet" type="text/css" href="/css/my-login.css">
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }

        .CentradoObjetos
        {
            -webkit-writing-mode: vertical-rl;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div style="background-image: url('../img/backGround.jpg'); width: 100%; height: 100%; position: fixed; z-index: auto; text-align: center;">
            <br />
            <br />
            <br />
            <br />
            <br />
            <span class="text-white">
            <strong><span class="auto-style1">BIENVENIDO A SOCIAL MEDIA</span></strong><br />
            </span>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/gmail.png" Width="50px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Por medidas de seguridad para ingresar debe validar con el codigo enviado a su correo electronico gracias :)" CssClass="text-white"></asp:Label>
            <br class="text-white" />
            <br />
            <table style="width:100%;" class="CentradoObjetos">
                <tr>
                    <td>
                <asp:TextBox ID="uitxtNombreTipoProd" runat="server" CssClass=" form-control" Width="30%"></asp:TextBox>
									<button type="submit" id="btnIngresar" runat="server" onserverclick="btnIngresar_Click" class="btn btn-primary btn-block" style="width: 100px">
										Validar</button>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="uiStatusCodigo" runat="server" CssClass="text-danger"></asp:Label>
        </div>
    </form>
</body>
</html>
