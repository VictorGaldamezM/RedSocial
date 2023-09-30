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
    public partial class Login : System.Web.UI.Page
    {
        ConexionPostgres conectado = new ConexionPostgres();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public string GenerateCode(int p_CodeLength)
        {
            string result = "";
            string pattern = "0123456789abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            Random myRndGenerator = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < p_CodeLength; i++)
            {
                int mIndex = myRndGenerator.Next(pattern.Length);
                result += pattern[mIndex];
            }

            return result;
        }
        

            protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String correo_electronico = email.Value;
            Session["correo_envio_compra"] = correo_electronico;
            String contraseña_usuario = password.Value;
            String codigoVerificacion = GenerateCode(4);

            DataTable tabla = conectado.validar_usuario(correo_electronico,contraseña_usuario);


            if (tabla.Rows.Count.ToString() =="0")
            {
                Label1.Text = "usuario o contraseña incorrectos";
                Label1.ForeColor = Color.Red;

            }
            else
            {
                Label1.Text = "usuario validado";
                Label1.ForeColor = Color.Green;
                Session["usuarioLogin"] = tabla.Rows[0]["id_usuario"].ToString();
                Session["nombreUsuario"] = tabla.Rows[0]["nombre_usuario"].ToString();


                int idUsuario = Convert.ToInt32(Session["usuarioLogin"].ToString());

                conectado.ActualizarCodigos(idUsuario);
                conectado.generarCodigoEmail(idUsuario, codigoVerificacion);
                conectado.enviar_correo(correo_electronico, Session["nombreUsuario"].ToString(),codigoVerificacion);

                Response.Redirect("validador.aspx");    
            }

        }
    }
}