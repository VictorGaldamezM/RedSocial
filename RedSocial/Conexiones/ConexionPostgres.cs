using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace app_inventario
{
    class ConexionPostgres
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password=12345; Database = APP_SOCIAL");

        public void conectar()
        {
            try
            {
                conn.Open();
            }
            catch
            {
            }
        }

        public void desconectar()
        {
            try
            {
                conn.Close();
            }
            catch
            {
            }
        }

        public DataTable validarCodigoIngreso(String idUsuario, String codigoVerif)
        {
            string query = "SELECT \"ID_USUARIO\" FROM \"APP_VERIFICACION_USUARIO\" WHERE \"ESTADO\" = 1 AND \"ID_USUARIO\"  = '" + idUsuario + "' AND \"CODIGO_VERIFICACION\"  = '" + codigoVerif + "'  ;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


        public DataTable validar_usuario(String correo_electronico, String contraseña_usuario)
        {
            string query = "SELECT \"ID_USUARIO\",\"NOMBRE_USUARIO\" FROM \"APP_USUARIO\" WHERE \"CORREO_USUARIO\"  = '" + correo_electronico + "' AND \"CONTRA_USUARIO\" = '" + contraseña_usuario + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable validarCorreo(String correo_electronico)
        {
            string query = "SELECT \"ID_USUARIO\" FROM \"APP_USUARIO\" WHERE \"CORREO_USUARIO\"  = '" + correo_electronico + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable verDatosUsuario(String id_usuario)
        {
            string query = "SELECT * FROM \"APP_USUARIO\" WHERE \"ID_USUARIO\"  = " + id_usuario + ";";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


        public DataTable crear_usuario(String correo_electronico, String nombre_usuario, String contraseña_usuario)
        {
            String perfil_default = "~/imagenesUsuarios/default.png";
            String fondo_defaul = "~/imagenesFondos/fondoDefault.jpg";

            string query = "INSERT INTO \"APP_USUARIO\" (\"ID_USUARIO\" ,\"NOMBRE_USUARIO\", \"CORREO_USUARIO\", \"CONTRA_USUARIO\", \"FECHA_ING\", \"PATH_PERFIL\",\"PATH_FONDO\") VALUES( NEXTVAL('SQ_USUARIO') ,'" + nombre_usuario + "' , '" + correo_electronico + "' , '" + contraseña_usuario + "', now(), '"+perfil_default+"', '"+fondo_defaul+"'); ";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


        public void enviar_correo(String correo_envio, String nombre_usuario, String codigo)
        {

            string body =
                "<body>" +
                "<h1>Bienvenido a Social Media</h1>" +
                "<h4>" + nombre_usuario + "</h4>" +
                "<h4> Su codigo para ingreso es: " + codigo + "</h4>" +
                "<br/><br/>Gracias por su preferencia :)" +
                "</body>";

            string deDireccionOrigen = "teciogt1000@gmail.com";

            MailMessage message = new MailMessage();

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = deDireccionOrigen,
                Password = "hgdlxascfwrqunay"
            };

            smtpClient.EnableSsl = true;
            message.From = new MailAddress(deDireccionOrigen);
            message.To.Add(new MailAddress(correo_envio));
            message.Subject = "Validacion de Codigo para ingreso";
            message.IsBodyHtml = true;
            message.Body = body;

            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);

        }

        public DataTable generarCodigoEmail(int idUsuario, String CodigoVerificacion)
        {
            string query = "INSERT INTO \"APP_VERIFICACION_USUARIO\" (\"ID_USUARIO\", \"CODIGO_VERIFICACION\", \"FECHA_INGRESO\", \"ESTADO\") VALUES (" + idUsuario + ",  '" + CodigoVerificacion + "', now(), 1);";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ActualizarCodigos(int idUsuario)
        {
            string query = "UPDATE \"APP_VERIFICACION_USUARIO\" SET \"ESTADO\" = 0 WHERE \"ID_USUARIO\" = " + idUsuario + "  ;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ActualizarDatosUsuario(String Nombre,String genero, String FechaNac, String pathPerfil, String pathFondo, String idUsuario)
        {
            string query = "UPDATE \"APP_USUARIO\" SET \"NOMBRE_USUARIO\" = '"+Nombre+ "', \"GENERO\" = '"+genero+ "', \"FECHA_NACIMIENTO\" = '"+FechaNac+ "', \"PATH_PERFIL\" = '"+pathPerfil+ "', \"PATH_FONDO\" = '"+pathFondo+"' WHERE \"ID_USUARIO\" = " + idUsuario + "  ;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


        public DataTable crearComentario(String idUsuario, String comentario,String imagenComentario)
        {
            string query = "INSERT INTO public.\"APP_COMENTARIO\"(\"ID_COMENTARIO\", \"COMENTARIO\", \"PATH_IMAGEN_COMENT\", \"FECHA_INGRESO\", \"USUARIO_INGRESO\", \"ESTADO\") VALUES (NEXTVAL('SQ_COMENTARIO'), '"+ comentario + "', '"+imagenComentario+"', now(), "+idUsuario+", 1);";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable verPublicaciones(String idUsuario)
        {
            string query = "SELECT * FROM public.\"APP_COMENTARIO\" A LEFT JOIN \"APP_USUARIO\" B ON (A.\"USUARIO_INGRESO\" = B.\"ID_USUARIO\")  WHERE \"USUARIO_INGRESO\" = " + idUsuario+ " AND \"ESTADO\" =1  ORDER BY \"ID_COMENTARIO\" DESC;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable buscarAmigos(String nombreUsuario, String idUsuario)
        {
            string query = "SELECT * FROM \"APP_USUARIO\" WHERE \"ID_USUARIO\" not in ('" + idUsuario + "') AND \"NOMBRE_USUARIO\" ILIKE '%" + nombreUsuario + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable agregarAmistad(String idUsuario,String idUsuarioAmistad)
        {
            string query = "INSERT INTO public.\"APP_AMISTAD\"(\"ID_USUARIO\", \"ID_USUARIO_AMISTAD\", \"FECHA_AMISTAD\", \"ESTADO\",\"ID_AMISTAD\") VALUES (" + idUsuario+", "+ idUsuarioAmistad + ", now(), 1,NEXTVAL('SQ_AMISTAD'));";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable agregarAmistadfin(String idUsuario, String idUsuarioAmistad)
        {
            string query = "INSERT INTO public.\"APP_AMISTAD\"(\"ID_USUARIO\", \"ID_USUARIO_AMISTAD\", \"FECHA_AMISTAD\", \"ESTADO\",\"ID_AMISTAD\") VALUES (" + idUsuario + ", " + idUsuarioAmistad + ", now(), 2,NEXTVAL('SQ_AMISTAD'));";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable buscarSolicitudesAmistad(String idUsuario)
        {
            string query = "SELECT A.\"ID_USUARIO\",A.\"ID_USUARIO_AMISTAD\",A.\"FECHA_AMISTAD\",A.\"ESTADO\",A.\"ID_AMISTAD\",C.\"PATH_PERFIL\",C.\"NOMBRE_USUARIO\" FROM \"APP_AMISTAD\" A LEFT JOIN \"APP_USUARIO\" B ON (A.\"ID_USUARIO_AMISTAD\" = B.\"ID_USUARIO\") LEFT JOIN \"APP_USUARIO\" C ON (A.\"ID_USUARIO\" = C.\"ID_USUARIO\") WHERE A.\"ID_USUARIO_AMISTAD\" = "+idUsuario+" AND A.\"ESTADO\" = 1";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable AceptarSolicitudAmistad(String idAmistad)
        {
            string query = "UPDATE \"APP_AMISTAD\" SET \"ESTADO\" = 2 WHERE \"ID_AMISTAD\" = " + idAmistad + "  ;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable verComentariosVarios(String idUsuario)
        {
            string query = "SELECT * FROM (SELECT DISTINCT \"ID_COMENTARIO\", A.\"ESTADO\" AS \"ESTADO_COMENTARIO\", \"COMENTARIO\", \"PATH_IMAGEN_COMENT\", \"FECHA_INGRESO\",\"USUARIO_INGRESO\",\"NOMBRE_USUARIO\",\"CORREO_USUARIO\",\"CONTRA_USUARIO\",\"FECHA_ING\",\"PATH_PERFIL\",\"PATH_FONDO\",\"FECHA_NACIMIENTO\",\"GENERO\" FROM public.\"APP_COMENTARIO\" A LEFT JOIN \"APP_USUARIO\" B ON (A.\"USUARIO_INGRESO\" = B.\"ID_USUARIO\") LEFT JOIN \"APP_AMISTAD\" C ON (B.\"ID_USUARIO\" = C.\"ID_USUARIO\" OR B.\"ID_USUARIO\" = C.\"ID_USUARIO_AMISTAD\")WHERE A.\"USUARIO_INGRESO\" = " + idUsuario+ " OR C.\"ID_USUARIO\" = " + idUsuario + " OR C.\"ID_USUARIO_AMISTAD\" = " + idUsuario + " AND C.\"ESTADO\" = 2 ORDER BY \"ID_COMENTARIO\" DESC) A WHERE A.\"ESTADO_COMENTARIO\" = 1 ";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable verificarAmistad(String idUsuario)
        {
            string query = "select * from \"APP_AMISTAD\" WHERE \"ID_USUARIO\" = 4 OR \"ID_USUARIO_AMISTAD\" = "+ idUsuario + "";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable eliminarComentario(String idComentario)
        {
            string query = "UPDATE \"APP_COMENTARIO\" SET \"ESTADO\" = 2 WHERE \"ID_COMENTARIO\" = " + idComentario + "  ;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable buscarAmigos(String idUsuario)
        {
            string query = "SELECT * FROM(SELECT CONCAT(CASE WHEN \"ID_USUARIO\" = " + idUsuario + " THEN \"ID_USUARIO_AMISTAD\" END ,CASE WHEN \"ID_USUARIO_AMISTAD\" = " + idUsuario + " THEN \"ID_USUARIO\" END) AS USUARIO FROM \"APP_AMISTAD\" WHERE \"ID_USUARIO\" = " + idUsuario + " OR \"ID_USUARIO_AMISTAD\" = " + idUsuario+" AND \"ESTADO\" = 2) A LEFT JOIN \"APP_USUARIO\" B ON (A.\"usuario\" = Cast(B.\"ID_USUARIO\" as varchar(10)));";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


    }
}
