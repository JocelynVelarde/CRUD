using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using CRUD.Modelo;
using System.Data.SQLite;

namespace CRUD.Logica
{
    public class UsuarioLogico
    {
        //SE ESTABLECE LA CADENA DE CONEXION CON LA BASE DE DATOS 
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        //SE CREA UNA INSTANCIA UNICA DEL USUARIO
        private static UsuarioLogico _instancia = null;

        //DECLARAR EL CONSTRUCTOR
        public UsuarioLogico()
        {

        }

        public static UsuarioLogico Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    
                   _instancia = new UsuarioLogico();
                }  
                return _instancia;
            }
        }

        //METODO QUE GUARDA LOS VALORES
        public bool Guardar(Usuario obj)
        {
            bool respuesta = true;

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //HACE LA CONSULTA EN LA TABLA USUARIOS CON LOS VALORES ESPECIFICADOS
                conexion.Open();
                string query = "insert into Usuario(Nombre,Contraseña,Cargo) values (@nombre,@contraseña,@cargo)";

                //SE AGREGAN PARAMETROS POR CADA FILA
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@contraseña", obj.Contraseña));
                cmd.Parameters.Add(new SQLiteParameter("@cargo", obj.Cargo));
                //SE LE INDICA QUE ES DE TIPO TEXTO
                cmd.CommandType = System.Data.CommandType.Text;

                //SI A LA TABLA NO SE LE AGREGAN ELEMENTOS EL NUMERO DE FILAS AFECTADA SERA MENOR A 1, POR LO TANTO LA RESPUESTA ES FALSA
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //SE CREA UNA LISTA PARA PODER VISUALIZAR A LOS USUARIOS
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //HACE LA CONSULTA EN LA TABLA USUARIOS CON LOS VALORES ESPECIFICADOS
                conexion.Open();
                string query = "select Id,Nombre,Contraseña,Cargo from Usuario";

                //SE AGREGAN PARAMETROS POR CADA FILA
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
          
                //SE LE INDICA QUE ES DE TIPO TEXTO
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Usuario()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Contraseña = dr["Contraseña"].ToString(),
                            Cargo = dr["Cargo"].ToString(),
                        });
                        }
                    }
                }

            return lista; 
        }

        public bool Editar(Usuario obj)
        {
            bool respuesta = true;

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //ACTUALIZA LA DB DE ACUERDO A LA NUEVA INFORMACION AGREGADA
                conexion.Open();
                string query = "Update Usuario set Nombre = @nombre ,Contraseña = @contraseña,Cargo = @cargo where Id = @id";

                //SE AGREGAN PARAMETROS POR CADA FILA
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@contraseña", obj.Contraseña));
                cmd.Parameters.Add(new SQLiteParameter("@cargo", obj.Cargo));
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.Id));
                //SE LE INDICA QUE ES DE TIPO TEXTO
                cmd.CommandType = System.Data.CommandType.Text;

                //SI A LA TABLA NO SE LE AGREGAN ELEMENTOS EL NUMERO DE FILAS AFECTADA SERA MENOR A 1, POR LO TANTO LA RESPUESTA ES FALSA
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }
}
