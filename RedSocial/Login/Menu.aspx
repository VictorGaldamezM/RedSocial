<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ProyectoFinalInventario2022.Login.Menu" %>
<!DOCTYPE html>
<html>
<head>
    	<meta charset="utf-8">
	<meta name="author" content="Kodinger">
	<meta name="viewport" content="width=device-width,initial-scale=1">
	<title>Login</title>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
	<link rel="stylesheet" type="text/css" href="/css/my-login.css">
    <link href="//fonts.googleapis.com/css?family=Lobster" rel="stylesheet" type="text/css">
    <link href="//fonts.googleapis.com/css?family=Nova+Slim" rel="stylesheet" type="text/css">

<style>
    

    .bordearImgComent{
 
  border-radius: 10px;
  border: 2px solid #eeeee4;

    }
        .bordearImg{
 width: 80px;
	height: 80px;
	object-fit: cover;
	border: 3px solid #ff9daa;
  border-radius: 50%;
  border: 5px solid white;

    }



    .eye{
  position:absolute;
  height:120px;
  width:123px;
  top: 19px;
  border-radius: 50%;
  left : 438px;
  border: 5px solid white;
  z-index: 1;
        margin-right: 0px;
    }

.heaven
{
  position:absolute;
  height:400px;
  width:600px;
  z-index: -1;
  border-radius: 20%;
        top: 5px;
        left: 196px;
        margin-top: 0px;
    }

    .Movimiento{
            -webkit-animation: slide-right 2s infinite ;
	        animation: slide-right 2s infinite ;
    }

    @-webkit-keyframes slide-right {
  0% {
    -webkit-transform: translateX(0);
            transform: translateX(0);
  }
  100% {
    -webkit-transform: translateX(100px);
            transform: translateX(100px);
  }
}
@keyframes slide-right {
  0% {
    -webkit-transform: translateX(0);
            transform: translateX(0);
  }
  100% {
    -webkit-transform: translateX(100px);
            transform: translateX(100px);
  }
}

 .form-popup {
  display: none;
  position: fixed;
  bottom: 0;
  right: 15px;
  border: 3px solid #f1f1f1;
  z-index: 9;
}

/* Add styles to the form container */
.form-container {
  max-width: 300px;
  padding: 10px;
  background-color: white;
}

/* Full-width input fields */
.form-container input[type=text], .form-container input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  border: none;
  background: #f1f1f1;
}

/* When the inputs get focus, do something */
.form-container input[type=text]:focus, .form-container input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

/* Set a style for the submit/login button */
.form-container .btn {
  background-color: #04AA6D;
  color: white;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  width: 100%;
  margin-bottom:10px;
  opacity: 0.8;
}

/* Add a red background color to the cancel button */
.form-container .cancel {
  background-color: red;
}

/* Add some hover effects to buttons */
.form-container .btn:hover, .open-button:hover {
  opacity: 1;
}






    .clickEfect:active {
    transform:scale(0.9);
}


body {
  margin: 0;
}

ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  width: 15%;
  background-color: #001c2a;
  position: fixed;
  height: 100%;
  overflow: auto;
}

li a {
  display: block;
  color: white;
  padding: 8px 16px;
  text-decoration: none;
}

li a.active {
  background-color: #029EF2;
  color: white;
}

li a:hover:not(.active) {
  background-color: #555;
  color: white;
}



.file-upload {
    display: inline-block;
    overflow: hidden;
    text-align: center;
    vertical-align: middle;
    font-family: Arial;
    border: 1px solid #124d77;
    background: #007dc1;
    color: #fff;
    border-radius: 6px;
    -moz-border-radius: 6px;
    cursor: pointer;
    text-shadow: #000 1px 1px 2px;
    -webkit-border-radius: 6px;
}

.file-upload:hover {
        background: -webkit-gradient(linear, left top, left bottom, color-stop(0.05, #0061a7), color-stop(1, #007dc1));
        background: -moz-linear-gradient(top, #0061a7 5%, #007dc1 100%);
        background: -webkit-linear-gradient(top, #0061a7 5%, #007dc1 100%);
        background: -o-linear-gradient(top, #0061a7 5%, #007dc1 100%);
        background: -ms-linear-gradient(top, #0061a7 5%, #007dc1 100%);
        background: linear-gradient(to bottom, #0061a7 5%, #007dc1 100%);
        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#0061a7', endColorstr='#007dc1',GradientType=0);
        background-color: #0061a7;
}

/* The button size */
.file-upload {
    height: 30px;
}

.file-upload, .file-upload span {
        width: 90px;
}

.file-upload input {
            top: 0;
            left: 0;
            margin: 0;
            font-size: 11px;
            font-weight: bold;
            /* Loses tab index in webkit if width is set to 0 */
            opacity: 0;
            filter: alpha(opacity=0);
}

.file-upload strong {
            font: normal 12px Tahoma,sans-serif;
            text-align: center;
            vertical-align: middle;
}

.file-upload span {
            top: 0;
            left: 0;
            display: inline-block;
            /* Adjust button text vertical alignment */
            padding-top: 5px;
}



.angry-grid {

   display:grid; 
   grid-template-rows: 3fr;
   grid-template-columns: 3fr;
   height: 100%;
   -webkit-writing-mode: vertical-lr;
       -webkit-text-combine: horizontal;
   
}

.angry-grid tr 
{
  width: 15%;
  margin: 0px;
  display: -webkit-inline-box;
}


.labelTextoHori
{
        -webkit-writing-mode: horizontal-tb;
        font-weight: 300!important;
}

.zoom:hover {
    transition: transform .4s;
  transform: scale(1.5); 
  background-color: #98FFCA;
  border-radius: 20px;
}

.zoomProducto:hover {
    transition: transform .4s;
  transform: scale(1.9); 
  background-color: #98FFCA;
}

.zoomProductoCarrito:hover {
    transition: transform .4s;
  transform: scale(1.9); 
}


    .gridEdicionDatos
    {
        border: 1px solid white;
        border-bottom: 1px solid #EBEBEB;
    }

     .gridEdicionDatos tr:hover
        {
            background-color: #E2F7FF;
        }

     .gridProductos
    {
        border: 1px solid white;
        border-bottom: 1px solid #EBEBEB;
    }




      .css-3d-text {
    font-size: 40px;
    color: #07a0ff;
    font-family: Lobster, cursive;
    text-shadow: 0px 0px 0 rgb(-17,136,231),
                 1px 1px 0 rgb(-32,121,216),
                 2px 2px 0 rgb(-48,105,200),
                 3px 3px  0 rgb(-64,89,184),
                 4px 4px 3px rgba(0,0,0,0.15),
                 4px 4px 1px rgba(0,0,0,0.5),
                 0px 0px 3px rgba(0,0,0,.2);
 }

       .css-3d-textAgot {
    font-size: 48px;
    color: #ff7b07;
    font-family: Lobster, cursive;
    text-shadow: 0px 0px 0 rgb(231,99,0),
                 1px 1px 0 rgb(216,84,0),
                 2px 2px 0 rgb(200,68,0),
                 3px 3px  0 rgb(184,52,0),
                 4px 4px 3px rgba(0,0,0,0.15),
                 4px 4px 1px rgba(0,0,0,0.5),
                 0px 0px 3px rgba(0,0,0,.2);
 }

       .css-3d-PRECIO {
font-size: 25PX;
    -WEBKIT-TEXT-STROKE: THIN;
    }

    .auto-style1 {
        font-size: medium;
    }

    .auto-style2 {
        height: 102px;
    }

    </style>
</head>
<body>

    <form id="form1" runat="server" enctype="multipart/form-data">

<ul>
  <li><a id="verPerfil" runat="server" style="color:white" onserverclick="verPerfil_Click">Perfil</a></li>
  <li><a id="verMuro" runat="server" style="color:white"  onserverclick="verMuro_Click">Publicaciones</a></li>
  <li><a id="buscarAmigos" runat="server" style="color:white" onserverclick="buscarAmigos_Click">Buscar Amigos</a></li>  
  <li><a id="verAmigos" runat="server" style="color:white" onserverclick="verAmigos_Click">Amigos</a></li>  
  <li><a id="verSolicitudes" runat="server" style="color:white" onserverclick="verSolicitudes_Click">Solicitudes de Amistad</a></li>  
  <li><a id="About" runat="server" style="color:white" onserverclick="About_Click">Acerca de Nosotros</a></li>
    <li><a id="btnCerrarSesion" runat="server" style="color:white" onserverclick="btnCerrarSesion_Click">Cerrar Sesión</a></li>
</ul>

<div style="margin-left:25%;padding:1px 16px;height:1000px;">
    <h2>&nbsp;</h2>
    <h2>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <h2>Perfil de Usuario</h2>
                <br />
                <br />
                <br />
                <br />

                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />

                <br />
                <div style="position: relative; left: 2px; top: -436px; margin-top: 0px;">
                    <asp:Image ID="uiImgFotoPerfilUsuario" runat="server" CssClass="eye" />
                    <asp:Image ID="uiFondoUsuario" runat="server" CssClass="heaven" />
                </div>
                <br />
                <h2><span class="auto-style1">Bienvenido: </span>
                    <asp:Label ID="uiNombreUsuario" runat="server" style="color: #808080" CssClass="auto-style1"></asp:Label>
                </h2>
                <h2><span class="auto-style1">Genero: </span>
                    <asp:Label ID="uiGeneroUsuario" runat="server" CssClass="auto-style1" style="color: #808080"></asp:Label>
                </h2>
                <h2><span class="auto-style1">Fecha Nacimiento: </span>
                    <asp:Label ID="uiFechaNacimiento" runat="server" CssClass="auto-style1" style="color: #808080"></asp:Label>
                </h2>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" CssClass="zoom" ImageUrl="~/img/rueda-dentada.png" ToolTip="Editar Perfil" Width="40px" OnClick="ImageButton1_Click" />
                <br />
                <br />
                <asp:GridView ID="uiGridComentariosPropios" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="gridProductos" OnPageIndexChanging="uiGridComentariosPropios_PageIndexChanging" PageSize="8" ShowHeader="False" Width="80%">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                &nbsp;&nbsp;<table style="width:100%;">
                                    <tr>
                                        <td style="border: thin dotted #CCCCCC">
                                            <table style="width:100%;">
                                                <tr>
                                                    <td style="background-color: #F3F3F5; text-align: right;">
                                                        <asp:Label ID="Label51" runat="server" style="color: #000000; font-weight: 700" Text='<%# Session["usuarioLogin"] %>' Visible="False"></asp:Label>
                                                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/img/trash-bin.png" OnClick="ImageButton5_Click" ToolTip="Eliminar Comentario" Visible='<%# Convert.ToString(Eval ("usuario_ingreso")) == Convert.ToString(Session["usuarioLogin"]) ? true: false %>' Width="30px" />
                                                    </td>
                                                </tr>
                                            </table>
                                            <strong>
                                            <br />
                                            <span class="auto-style1">Fecha Comentario:</span></strong><span class="auto-style1">&nbsp; </span>
                                            <asp:Label ID="Label52" runat="server" CssClass="auto-style1" Text="<%# bind('fecha_ing') %>"></asp:Label>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style2" style="border: thin dotted #CCCCCC">
                                            <asp:Image ID="Image5" runat="server" CssClass="bordearImg" Height="90px" ImageUrl="<%# BIND('PATH_PERFIL') %>" Width="90px" />
                                            <asp:Label ID="Label53" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('nombre_usuario') %>"></asp:Label>
                                            <asp:Label ID="Label54" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('id_comentario') %>" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border: thin dotted #CCCCCC"><strong>
                                            <br />
                                            Comentario:</strong>&nbsp;<br />
                                            <asp:Label ID="Label55" runat="server" Text="<%# bind('comentario') %>"></asp:Label>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border: thin dotted #CCCCCC; text-align: center">
                                            <br />
                                            <asp:Image ID="Image6" runat="server" CssClass="bordearImgComent" Height="300px" ImageUrl="<%# bind('path_imagen_coment') %>" Visible='<%# Eval ("path_imagen_coment") == "" ? false: true %>' Width="600px" />
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
            </asp:View>
             <asp:View ID="View2" runat="server">
                 <h2>Edición de Perfil</h2>
                 <br />
                 <asp:Label ID="Label1" runat="server" CssClass="font-weight-light" Text="Nombre Usuario"></asp:Label>
                 <asp:TextBox ID="uiTxtNuevoNombre" runat="server" CssClass=" form-control" Width="80%"></asp:TextBox>
                 <br />
                 <asp:Label ID="Label2" runat="server" CssClass="font-weight-light" Text="Genero"></asp:Label>
                 <asp:DropDownList ID="uiNuevoGenero" runat="server" CssClass=" form-control" Width="80%">
                     <asp:ListItem>Masculino</asp:ListItem>
                     <asp:ListItem>Femenino</asp:ListItem>
                     <asp:ListItem>Sin Definir</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <asp:Label ID="Label41" runat="server" CssClass="font-weight-light" Text="Fecha Nacimiento"></asp:Label>
                 <asp:TextBox ID="uiTxtNuevaFecha" runat="server" CssClass=" form-control" TextMode="Date" Width="80%"></asp:TextBox>
                 <br />
                 <asp:Label ID="Label3" runat="server" CssClass="font-weight-light" Text="Foto de Perfil"></asp:Label>
                 <br />
                 <asp:FileUpload ID="FileUpload1" runat="server" CssClass="file-upload" Width="80%" />
                 <br />
                 <br />
                 <asp:Label ID="Label5" runat="server" CssClass="font-weight-light" Text="Fondo de Perfil"></asp:Label>
                 <br />
                 <asp:FileUpload ID="FileUpload2" runat="server" CssClass="file-upload" Width="80%" />
                 <br />
                 <br />
                 <br />
                 <button id="btnActualizarDatos" runat="server" class="btn btn-primary btn-block" onserverclick="btnActualizarDatos_Click" type="submit" style="width: 30%">
                     Actualizar datos
                 </button>
                 <br />
                 <asp:Label ID="Label4" runat="server" CssClass="font-weight-light"></asp:Label>
                 <br />
                 <br />
                 </asp:View>
            <asp:View ID="View3" runat="server">
                 <h2>Publicaciones :)</h2>
                 <br />
                 <br />
                 <asp:Label ID="Label42" runat="server" CssClass="font-weight-light" Text="Comentario"></asp:Label>
                 <asp:TextBox ID="uiTxtComentario" runat="server" CssClass=" form-control" Height="100px" TextMode="MultiLine" Width="80%"></asp:TextBox>
                 <br />
                 <asp:Label ID="uitxtFotoComentario" runat="server" CssClass="font-weight-light" Text="Imagen de Comentario"></asp:Label>
                 <br />
                 <asp:FileUpload ID="FileUpload3" runat="server" CssClass="file-upload" Width="80%" />
                 <br />
                 <br />
                 <asp:Label ID="Label43" runat="server" CssClass="font-weight-light"></asp:Label>
                 <br />
                 <table style="width:100%;">
                     <tr>
                         <td style="width: 40%">&nbsp;</td>
                         <td style="text-align: left">
                             <asp:ImageButton ID="ImageButton2" runat="server" CssClass="zoom" ImageUrl="~/img/plus.png" OnClick="ImageButton2_Click" ToolTip="Crear Comentario" Width="30px" />
                         </td>
                         <td>&nbsp;</td>
                     </tr>
                 </table>
                 <br />
                 <asp:GridView ID="uiGridComentarios" runat="server" AutoGenerateColumns="False" CssClass="gridProductos" OnPageIndexChanging="uiGridComentarios_PageIndexChanging" ShowHeader="False" Width="80%" AllowPaging="True" PageSize="8">
                     <Columns>
                         <asp:TemplateField>
                             <ItemTemplate>
                                 &nbsp;&nbsp;<table style="width:100%;">
                                     <tr>
                                         <td style="border: thin dotted #CCCCCC">
                                             <table style="width:100%;">
                                                 <tr>
                                                     <td style="background-color: #F3F3F5; text-align: right;">
                                                         <asp:Label ID="Label37" runat="server" style="color: #000000; font-weight: 700" Text='<%# Session["usuarioLogin"] %>' Visible="False"></asp:Label>
                                                         <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/trash-bin.png" OnClick="ImageButton4_Click" ToolTip="Eliminar Comentario" Visible='<%# Convert.ToString(Eval ("usuario_ingreso")) == Convert.ToString(Session["usuarioLogin"]) ? true: false %>' Width="30px" />
                                                     </td>
                                                 </tr>
                                             </table>
                                             <strong>
                                             <br />
                                             <span class="auto-style1">Fecha Comentario:</span></strong><span class="auto-style1">&nbsp; </span>
                                             <asp:Label ID="Label34" runat="server" CssClass="auto-style1" Text="<%# bind('fecha_ing') %>"></asp:Label>
                                             <br />
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="auto-style2" style="border: thin dotted #CCCCCC">
                                             <asp:Image ID="Image1" runat="server" CssClass="bordearImg" ImageUrl="<%# BIND('PATH_PERFIL') %>" Width="90px" Height="90px" />
                                             <asp:Label ID="Label35" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('nombre_usuario') %>"></asp:Label>
                                             <asp:Label ID="Label36" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('id_comentario') %>" Visible="False"></asp:Label>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td style="border: thin dotted #CCCCCC"><strong>
                                             <br />
                                             Comentario:</strong>&nbsp;<br /> <asp:Label ID="Label33" runat="server" Text="<%# bind('comentario') %>"></asp:Label>
                                             <br />
                                         </td>
                                     </tr>
                                     <tr>
                                         <td style="border: thin dotted #CCCCCC; text-align: center">
                                             <br />
                                             <asp:Image ID="Image2" runat="server" Height="300px" ImageUrl="<%# bind('path_imagen_coment') %>" Visible='<%# Eval ("path_imagen_coment") == "" ? false: true %>' Width="600px" CssClass="bordearImgComent" />
                                             <br />
                                         </td>
                                     </tr>
                                 </table>
                             </ItemTemplate>
                         </asp:TemplateField>
                     </Columns>
                 </asp:GridView>
                 <br />
                <br />
                <br />
                 </asp:View>
            <asp:View ID="View4" runat="server">
                <h2>Buscar Amistades</h2>
                 <br />
                 <table style="width:80%">
                     <tr>
                         <td>
                             <input id="uitxtNombreAmigos" runat="server" class="form-control" name="textBusqueda" placeholder="Cual es el nombre de tu amigo? :D"  />
                         </td>
                         <td>
                             <asp:ImageButton ID="ImageButton3" runat="server" Height="20px" ImageUrl="~/img/lupa.png" OnClick="ImageButton3_Click1" ToolTip="Buscar" Width="20px" />
                         </td>
                     </tr>
                </table>
                <br />
                <asp:Label ID="Label46" runat="server" CssClass="font-weight-light"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="uiGridAmigosBuscar" runat="server" AutoGenerateColumns="False" CssClass="gridProductos" ShowHeader="False" Width="80%">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                &nbsp;&nbsp;
                                <table style="width:100%;">
                                    <tr>
                                        <td style="width: 40%">
                                            <asp:Image ID="Image3" runat="server" CssClass="bordearImg" ImageUrl="<%# BIND('PATH_PERFIL') %>" Width="90px" Height="90px" />
                                            <asp:Label ID="Label45" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('nombre_usuario') %>"></asp:Label>
                                            <br />
                                            <asp:Label ID="Label46" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('id_usuario') %>" Visible="False"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                        <td>
                                            <asp:Button ID="btnIngresarCarrito" runat="server" class="btn-dark" style="width: 40%; height: 45px; border-radius:5px" text='Agregar Amistad' type="submit" OnClick="btnIngresarCarrito_Click" OnCommand="btnIngresarCarrito_Command" />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                 <br />
                </asp:View>
            <asp:View ID="View5" runat="server">
                <h2>Ver Solicitudes de Amistad</h2>
                <br />
                <asp:Label ID="Label50" runat="server" CssClass="font-weight-light"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="uiGridSolicitudesAmistad" runat="server" AutoGenerateColumns="False" CssClass="gridProductos" ShowHeader="False" Width="80%">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                &nbsp;&nbsp;
                                <table style="width:100%;">
                                    <tr>
                                        <td style="width: 40%">
                                            <asp:Image ID="Image4" runat="server" CssClass="bordearImg" Height="90px" ImageUrl="<%# BIND('PATH_PERFIL') %>" Width="90px" />
                                            <asp:Label ID="Label47" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('nombre_usuario') %>"></asp:Label>
                                            <br />
                                            <asp:Label ID="Label48" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('id_amistad') %>" Visible="False"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label49" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('id_usuario') %>" Visible="False"></asp:Label>
                                        </td>
                                        <td>
                                            Fecha Amistad:
                                            <asp:Label ID="Label50" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('fecha_amistad') %>"></asp:Label>
                                            <br />
                                            <br />
                                            <asp:Button ID="btnAceptarSolicitud" runat="server" class="btn-dark" OnClick="btnAceptarSolicitud_Click" style="width: 40%; height: 45px; border-radius:5px" text="Aceptar Solicitud de Amistad" type="submit" />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                </asp:View>
            <asp:View ID="View6" runat="server">
                <h2>Amigos :D</h2>
                <br />
                <asp:GridView ID="uiGridAmigos" runat="server" AutoGenerateColumns="False" CssClass="gridProductos" ShowHeader="False" Width="80%">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                &nbsp;&nbsp;
                                <table style="width:100%;">
                                    <tr>
                                        <td style="width: 40%">
                                            <asp:Image ID="Image7" runat="server" CssClass="bordearImg" Height="90px" ImageUrl="<%# BIND('PATH_PERFIL') %>" Width="90px" />
                                            <asp:Label ID="Label56" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('nombre_usuario') %>"></asp:Label>
                                            <br />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label58" runat="server" style="color: #000000; font-weight: 700" Text="<%# bind('id_usuario') %>" Visible="False"></asp:Label>
                                        </td>
                                        <td>
                                            <br />
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                 </asp:View>
            <asp:View ID="View7" runat="server">
                        
                 <h2>Nombre de integrantes de Desarrollo:</h2>
                        <br />
                 <strong>Jimmy Francisco Guidos Sánchez</strong> Carne. 0494-10-10398<br />
                 <br />
                 <strong>Victor Alejandro Galdamez Marroquin</strong> Carne. 0900-19-14471<br />
                 <br />
                 <strong>Jorge Andrés Avalos Ortiz</strong> Carne. 0900-18-89<br />
                 <br />
                 <strong>Jose Ivan Salazar</strong> Carne. 0494-05-4804<br />
                 <br />
                 <strong>Leira Anahí Hernández Veliz</strong> Carne. 0494-15-16744<br />
                 <br />
                <br />
                 </asp:View>
        </asp:MultiView>
    </h2>
    <br />

</div>

    </form>

</body>
</html> 