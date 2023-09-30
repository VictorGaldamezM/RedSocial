using app_inventario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalInventario2022.Login
{
    public partial class register : System.Web.UI.Page
    {
        ConexionPostgres conectado = new ConexionPostgres();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uibtnCrearUsuario_Click(object sender, EventArgs e)
        {
            String nombre_usuario = name.Value;
            String correo_electronico = email.Value;
            String contraseña_usuario = password.Value;

            DataTable verifCorreo = conectado.validarCorreo(correo_electronico);

            if (nombre_usuario.Length == 0 || correo_electronico.Length == 0 || contraseña_usuario.Length == 0)
            {
                //faltan Datos
            }
            else
            {
                if (verifCorreo.Rows.Count > 0)
                {
                    Label1.Text = "Este correo ya posee una cuenta";
                    Label1.ForeColor = Color.Red;
                }
                else
                {
                    Label1.Text = "";
                    conectado.crear_usuario(correo_electronico, nombre_usuario, contraseña_usuario);
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}