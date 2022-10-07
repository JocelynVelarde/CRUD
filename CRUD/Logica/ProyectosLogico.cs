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
    public class ProyectosLogicos
    {
        //SE ESTABLECE LA CADENA DE CONEXION CON LA BASE DE DATOS 
        private static string cadenaP = ConfigurationManager.ConnectionStrings["cadenaP"].ConnectionString;

        //SE CREA UNA INSTANCIA UNICA DEL USUARIO
        private static ProyectosLogicos _instancia = null;

        //DECLARAR EL CONSTRUCTOR
        public ProyectosLogicos()
        {

        }

        public static ProyectosLogicos Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    
                   _instancia = new ProyectosLogicos();
                }  
                return _instancia;
            }
        }

        //METODO QUE GUARDA LOS VALORES
        public bool Guardar(Proyectos obj)
        {
            bool respuesta = true;

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaP))
            {
                //HACE LA CONSULTA EN LA TABLA USUARIOS CON LOS VALORES ESPECIFICADOS
                conexion.Open();
                string query = "insert into Ingreso(Concepto,Cantidad,Proyecto) values (@concepto,@cantidad,@proyecto)";

                //SE AGREGAN PARAMETROS POR CADA FILA
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@concepto", obj.Concepto));
                cmd.Parameters.Add(new SQLiteParameter("@cantidad", obj.Cantidad));
                cmd.Parameters.Add(new SQLiteParameter("@proyecto", obj.Proyecto));
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
        public List<Proyectos> Listar()
        {
            List<Proyectos> lista = new List<Proyectos>();

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaP))
            {
                //HACE LA CONSULTA EN LA TABLA USUARIOS CON LOS VALORES ESPECIFICADOS
                conexion.Open();
                string query = "select Id,Concepto,Cantidad,Proyecto from Ingreso";

                //SE AGREGAN PARAMETROS POR CADA FILA
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
          
                //SE LE INDICA QUE ES DE TIPO TEXTO
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Proyectos()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            Concepto = dr["Concepto"].ToString(),
                            Cantidad = dr["Cantidad"].ToString(),
                            Proyecto = dr["Proyecto"].ToString(),
                        });
                        }
                    }
                }

            return lista; 
        }

        public bool Editar(Proyectos obj)
        {
            bool respuesta = true;

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaP))
            {
                //ACTUALIZA LA DB DE ACUERDO A LA NUEVA INFORMACION AGREGADA
                conexion.Open();
                string query = "Update Ingreso set Concepto = @concepto ,Cantidad = @cantidad,Proyecto = @proyecto where Id = @id";

                //SE AGREGAN PARAMETROS POR CADA FILA
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Concepto));
                cmd.Parameters.Add(new SQLiteParameter("@contraseña", obj.Cantidad));
                cmd.Parameters.Add(new SQLiteParameter("@cargo", obj.Proyecto));
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

        //METODO PARA ELIMINAR TODOS LOS DATOS DE UNA FILA 
        public bool Eliminar(Proyectos obj)
        {
            bool respuesta = true;

            //ESTABLECE LA CONEXION EN LA CADENA
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaP))
            {
                //ACTUALIZA LA DB DE ACUERDO A LA NUEVA INFORMACION AGREGADA
                conexion.Open();
                string query = "delete from ingreso where Id = @id";

                //LOS OTROS PARAMETROS YA NO SON NECESARIOS YA QUE SOLO ESTAREMOS BORRANDO DONDE ID SEA DE USUARIO
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
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
