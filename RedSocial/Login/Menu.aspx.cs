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
    public partial class Menu : System.Web.UI.Page
    {
        ConexionPostgres conectado = new ConexionPostgres();
        protected void Page_Load(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();
            DataTable tabla = conectado.verDatosUsuario(idUsuario);

            uiImgFotoPerfilUsuario.ImageUrl = tabla.Rows[0]["PATH_PERFIL"].ToString();
            uiFondoUsuario.ImageUrl = tabla.Rows[0]["PATH_FONDO"].ToString();
            uiNombreUsuario.Text = tabla.Rows[0]["NOMBRE_USUARIO"].ToString();
            uiGeneroUsuario.Text = tabla.Rows[0]["GENERO"].ToString();
            uiFechaNacimiento.Text = tabla.Rows[0]["FECHA_NACIMIENTO"].ToString();

            if (tabla.Rows[0]["GENERO"].ToString() =="")
            {
                uiGeneroUsuario.Text = "Sin definir";
            }
            if (tabla.Rows[0]["FECHA_NACIMIENTO"].ToString() =="")
            {
                uiFechaNacimiento.Text = "Sin definir";
            }
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

        protected void verPerfil_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;

            String idUsuario = Session["usuarioLogin"].ToString();
            DataTable tabla = conectado.verDatosUsuario(idUsuario);

            uiImgFotoPerfilUsuario.ImageUrl = tabla.Rows[0]["PATH_PERFIL"].ToString();
            uiFondoUsuario.ImageUrl = tabla.Rows[0]["PATH_FONDO"].ToString();
            uiNombreUsuario.Text = tabla.Rows[0]["NOMBRE_USUARIO"].ToString();
            uiGeneroUsuario.Text = tabla.Rows[0]["GENERO"].ToString();
            uiFechaNacimiento.Text = tabla.Rows[0]["FECHA_NACIMIENTO"].ToString();

            uiGridComentariosPropios.DataSource = null;
            uiGridComentariosPropios.DataSource = conectado.verPublicaciones(idUsuario); ;
            uiGridComentariosPropios.DataBind();
 

            if (tabla.Rows[0]["GENERO"].ToString() == "")
            {
                uiGeneroUsuario.Text = "Sin definir";
            }
            if (tabla.Rows[0]["FECHA_NACIMIENTO"].ToString() == "")
            {
                uiFechaNacimiento.Text = "Sin definir";
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();
            String nuevoNombre = uiTxtNuevoNombre.Text;
            String nuevoGenero = uiNuevoGenero.SelectedValue.ToString();
            String nuevaFechaNac = uiTxtNuevaFecha.Text;
            String codImagenTipoProd = GenerateCode(10);

            string[] validFileTypes = { "png", "jpg", "jpeg" };
            bool isValidFile = false;
            bool isValidFile2 = false;

            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            string ext2 = System.IO.Path.GetExtension(FileUpload2.PostedFile.FileName);

            String path_imagen = "";
            String path_imagen2 = "";
            string ruta = "";
            string ruta2 = "";

            if (FileUpload1.HasFile == false)
            {
                path_imagen = "";
            }
            else
                path_imagen = "1";

            for (int i = 0; i < validFileTypes.Length; i++)

            {
                if (ext == "." + validFileTypes[i])
                {
                    isValidFile = true;
                }
            }

            if (FileUpload2.HasFile == false)
            {
                path_imagen2 = "";
            }
            else
                path_imagen2 = "1";

            for (int i = 0; i < validFileTypes.Length; i++)

            {
                if (ext2 == "." + validFileTypes[i])
                {
                    isValidFile2 = true;
                }
            }


            if (nuevoNombre == "" || nuevoGenero == "" || nuevaFechaNac == "" || path_imagen == "" || path_imagen2 == "")
            {
                Label4.Text = "Faltan datos para actualizar Datos";
                Label4.ForeColor = Color.Red;
            }
            else
            {

                if (!isValidFile || !isValidFile2)

                {
                    Label4.Text = "Error en extensión de archivo";
                    Label4.ForeColor = Color.Red;

                }
                else
                {
                    string nombreArchivo = FileUpload1.FileName;
                    string nombreArchivo2 = FileUpload2.FileName;

                    ruta = "~/imagenesUsuarios/" + codImagenTipoProd + "-" + nombreArchivo;
                    ruta2 = "~/imagenesFondos/" + codImagenTipoProd + "-" + nombreArchivo2;

                    conectado.ActualizarDatosUsuario(nuevoNombre,nuevoGenero,nuevaFechaNac, ruta, ruta2, idUsuario);

                    FileUpload1.SaveAs(Server.MapPath(ruta));
                    FileUpload2.SaveAs(Server.MapPath(ruta2));

                    Label4.Text = "Datos Actualizados";
                    Label4.ForeColor = Color.Green;
                }
            }
        }

        protected void verMuro_Click(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();

            uiGridComentarios.DataSource = null;
            uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario); ;
            uiGridComentarios.DataBind();

            MultiView1.ActiveViewIndex = 2;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            uiGridComentarios.DataSource = null;
            uiGridComentarios.DataBind();

            String idUsuario = Session["usuarioLogin"].ToString();
            String comentario = uiTxtComentario.Text;
            string[] validFileTypes = { "png", "jpg", "jpeg" };
            bool isValidFile = false;
            string ext = System.IO.Path.GetExtension(FileUpload3.PostedFile.FileName);
            String path_imagen = "";
            string ruta = "";
            String codImagenTipoProd = GenerateCode(10);


            if (FileUpload3.HasFile == false)
            {
                path_imagen = "";
            }
            else
                path_imagen = "1";

            for (int i = 0; i < validFileTypes.Length; i++)

            {
                if (ext == "." + validFileTypes[i])
                {
                    isValidFile = true;
                }
            }

            if(comentario =="" && path_imagen == "")
            {
                uiGridComentarios.DataSource = null;
                uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario); ;
                uiGridComentarios.DataBind();

                Label43.Text = "Faltan Datos :(";
                Label43.ForeColor = Color.Red;
            }
            else
            {
                if (path_imagen=="" && comentario !="")
                {
                   conectado.crearComentario(idUsuario,comentario,path_imagen);

                   uiGridComentarios.DataSource = null;
                   uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario); ;
                   uiGridComentarios.DataBind();
                   Label43.Text = "";
                }
            
                if (path_imagen!= "" && comentario == "")
                {
                    string nombreArchivo = FileUpload3.FileName;
                    ruta = "~/ImagenesComentarios/" + codImagenTipoProd + "-" + nombreArchivo;
                    FileUpload3.SaveAs(Server.MapPath(ruta));
                    conectado.crearComentario(idUsuario, comentario, ruta);

                    uiGridComentarios.DataSource = null;
                    uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario); ;
                    uiGridComentarios.DataBind();
                    Label43.Text = "";
                }

               if (path_imagen != "" && comentario != "")
                {
                    string nombreArchivo = FileUpload3.FileName;
                    ruta = "~/ImagenesComentarios/" + codImagenTipoProd + "-" + nombreArchivo;
                    FileUpload3.SaveAs(Server.MapPath(ruta));
                    conectado.crearComentario(idUsuario, comentario, ruta);

                    uiGridComentarios.DataSource = null;
                    uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario); 
                    uiGridComentarios.DataBind();
                    Label43.Text = "";
                }
          }
         uiTxtComentario.Text = "";
        }

        protected void uiGridComentarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();

            uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario); 
            uiGridComentarios.PageIndex = e.NewPageIndex;
            uiGridComentarios.DataBind();
        }
        protected void buscarAmigos_Click(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();

            MultiView1.ActiveViewIndex = 3;
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click1(object sender, ImageClickEventArgs e)
        {
            String nombreAmigo = uitxtNombreAmigos.Value;
            String idUsuario = Session["usuarioLogin"].ToString();

            DataTable tabla = conectado.buscarAmigos(nombreAmigo, idUsuario);

            if(tabla.Rows.Count.ToString() == "0")
            {
                uiGridAmigosBuscar.DataSource = null;
                uiGridAmigosBuscar.DataBind();
                Label46.Text = "no existen usuario con ese nombre :(";
                Label46.ForeColor = Color.Red;
            }
            else
            {
            uiGridAmigosBuscar.DataSource = null;
            uiGridAmigosBuscar.DataSource = conectado.buscarAmigos(nombreAmigo, idUsuario);
            uiGridAmigosBuscar.DataBind();
            Label46.Text = "";
            }
        }

        protected void btnIngresarCarrito_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnIngresarCarrito_Click(object sender, EventArgs e)
        {
            Button itemSelected = (Button)sender;
            GridViewRow row = (GridViewRow)itemSelected.NamingContainer;
            Int32 rowSelected = row.RowIndex;
            String nombreAmigo = uitxtNombreAmigos.Value;

            String idUsuarioAmistad = Convert.ToString(((Label)uiGridAmigosBuscar.Rows[rowSelected].FindControl("Label46")).Text.Trim());

            String idUsuario = Session["usuarioLogin"].ToString();


            DataTable verif = conectado.verificarAmistad(idUsuario);

            if(verif.Rows.Count.ToString()=="0")
            {
                conectado.agregarAmistad(idUsuario, idUsuarioAmistad);

                uiGridAmigosBuscar.DataSource = null;
                uiGridAmigosBuscar.DataSource = conectado.buscarAmigos(nombreAmigo, idUsuario);
                uiGridAmigosBuscar.DataBind();
                Label46.Text = "";
            }
            else
            {
                uiGridAmigosBuscar.DataSource = null;
                uiGridAmigosBuscar.DataSource = conectado.buscarAmigos(nombreAmigo, idUsuario);
                uiGridAmigosBuscar.DataBind();

                Label46.Text = "Este usuario ya recibio tu solicitud de amistad";
                Label46.ForeColor = Color.Green;
            }
           
        }

        protected void verSolicitudes_Click(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();

            DataTable tabla = conectado.buscarSolicitudesAmistad(idUsuario);

            if(tabla.Rows.Count.ToString() =="0")
            {
                Label50.Text = "No tiene Solicitudes Nuevas :(";
                Label50.ForeColor = Color.Red;
            }
            else
            {
                uiGridSolicitudesAmistad.DataSource = null;
                uiGridSolicitudesAmistad.DataSource = conectado.buscarSolicitudesAmistad(idUsuario);
                uiGridSolicitudesAmistad.DataBind();
                Label50.Text = "";
            }
            MultiView1.ActiveViewIndex = 4;
        }

        protected void btnAceptarSolicitud_Click(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();
            Button itemSelected = (Button)sender;
            GridViewRow row = (GridViewRow)itemSelected.NamingContainer;
            Int32 rowSelected = row.RowIndex;
            String nombreAmigo = uitxtNombreAmigos.Value;

            String idUsuarioAmistad = Convert.ToString(((Label)uiGridSolicitudesAmistad.Rows[rowSelected].FindControl("Label48")).Text.Trim());
            String codUsAmistad = Convert.ToString(((Label)uiGridSolicitudesAmistad.Rows[rowSelected].FindControl("Label49")).Text.Trim());

            conectado.AceptarSolicitudAmistad(idUsuarioAmistad);

            uiGridSolicitudesAmistad.DataSource = null;
            uiGridSolicitudesAmistad.DataSource = conectado.buscarSolicitudesAmistad(idUsuario);
            uiGridSolicitudesAmistad.DataBind();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
            Session["usuarioLogin"] = "";
            Session["nombreUsuario"] = "";
            Session["correo_envio_compra"] = "";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();
            ImageButton itemSelected = (ImageButton)sender;
            GridViewRow row = (GridViewRow)itemSelected.NamingContainer;
            Int32 rowSelected = row.RowIndex;

            String codigoComentario = Convert.ToString(((Label)uiGridComentarios.Rows[rowSelected].FindControl("Label36")).Text.Trim());

            conectado.eliminarComentario(codigoComentario);

            uiGridComentarios.DataSource = null;
            uiGridComentarios.DataSource = conectado.verComentariosVarios(idUsuario);
            uiGridComentarios.DataBind();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();
            ImageButton itemSelected = (ImageButton)sender;
            GridViewRow row = (GridViewRow)itemSelected.NamingContainer;
            Int32 rowSelected = row.RowIndex;

            String codigoComentario = Convert.ToString(((Label)uiGridComentariosPropios.Rows[rowSelected].FindControl("Label54")).Text.Trim());

            conectado.eliminarComentario(codigoComentario);

            uiGridComentariosPropios.DataSource = null;
            uiGridComentariosPropios.DataSource = conectado.verPublicaciones(idUsuario);
            uiGridComentariosPropios.DataBind();
        }
        protected void verAmigos_Click(object sender, EventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();

            uiGridAmigos.DataSource = null;
            uiGridAmigos.DataSource = conectado.buscarAmigos(idUsuario);
            uiGridAmigos.DataBind();

            MultiView1.ActiveViewIndex = 5;

        }

        protected void uiGridComentariosPropios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            String idUsuario = Session["usuarioLogin"].ToString();

            uiGridComentariosPropios.DataSource = conectado.verPublicaciones(idUsuario);
            uiGridComentariosPropios.PageIndex = e.NewPageIndex;
            uiGridComentariosPropios.DataBind();
        }

        protected void About_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 6;
        }


        
    }

}