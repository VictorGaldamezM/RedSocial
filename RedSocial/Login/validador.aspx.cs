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
    public partial class validador : System.Web.UI.Page
    {
        ConexionPostgres conectado = new ConexionPostgres();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String codigoVerif = uitxtNombreTipoProd.Text;
            String idUsuario = Session["usuarioLogin"].ToString();

            DataTable tabla = conectado.validarCodigoIngreso(idUsuario,codigoVerif);

            if (tabla.Rows.Count.ToString() == "0")
            {
                uiStatusCodigo.Text = "Codigo no valido :(";
            }
            else
            {
                Response.Redirect("Menu.aspx");
            }

        }
    }
}