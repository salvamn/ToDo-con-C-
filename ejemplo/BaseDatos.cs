using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace ejemplo
{
    class BaseDatos
    {
        private SQLiteConnection conexion;
        private SQLiteCommand comando;
        private string ruta = @"data source = C:\Users\Salva\source\repos\ejemplo\ejemplo\todoseecharp.db";
        

        public List<string> devolver_proyectos()
        {
            var nombreProyectos = new List<string>();

            conexion = new SQLiteConnection(ruta);
            conexion.Open();
            
            string sql = "SELECT nombreProyecto FROM Proyecto";
            comando = new SQLiteCommand(sql, conexion);

            SQLiteDataReader data = comando.ExecuteReader();

            while(data.Read())
            {
                string dato = data.GetString(0);
                nombreProyectos.Add(dato);
            }

            conexion.Close();

            return nombreProyectos;
        }


        public void insertar_proyecto(String nombre)
        {
            conexion = new SQLiteConnection(ruta);
            conexion.Open();
            comando = new SQLiteCommand(conexion);
            comando.CommandText = "INSERT INTO Proyecto(nombreProyecto) VALUES(@nombreProyecto)";

            comando.Parameters.AddWithValue("@nombreProyecto", nombre);
            comando.Prepare();
            comando.ExecuteNonQuery();

            conexion.Close();
        }


        public void insertar_tarea( string nombreTarea, string descripccion,
            string fechaInicio, string fechaFin, string nombreProyecto)
        {
            conexion = new SQLiteConnection(ruta);
            conexion.Open();

            comando = new SQLiteCommand(conexion);
            comando.CommandText = "INSERT INTO Tareas(" +
                "nombreTarea, descripccionTarea, fechaInicio, fechaFin, nombreProyecto) VALUES(" +
                "@nombreTarea, @descripccionTarea, @fechaInicio, @fechaFin, @nombreProyecto)";

            comando.Parameters.AddWithValue("@nombreTarea", nombreTarea);
            comando.Parameters.AddWithValue("@descripccionTarea", descripccion);
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
;           comando.Parameters.AddWithValue("@fechaFin", fechaFin);
            comando.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);
            comando.Prepare();
            comando.ExecuteNonQuery();

            conexion.Close();
        }


        public List<Array> devolver_tareas(string proyecto)
        {
            List<Array> tarea = new List<Array>();

            conexion = new SQLiteConnection(ruta);
            conexion.Open();

            string sql = $"SELECT * FROM Tareas WHERE nombreProyecto = '{proyecto}'";

            comando = new SQLiteCommand(sql, conexion);
            SQLiteDataReader data = comando.ExecuteReader();

            while (data.Read())
            {
                string id = data.GetInt32(0).ToString();
                string[] tareas = new string[6] {
                id,
                data.GetString(1),
                data.GetString(2),
                data.GetString(3),
                data.GetString(4),
                data.GetString(5)};

                tarea.Add(tareas);
                
            }

            conexion.Close();
            return tarea;
        }


        public void eliminar(string proyecto)
        {
            try
            {
                conexion = new SQLiteConnection(ruta);
                conexion.Open();
                comando = new SQLiteCommand(conexion);

                comando.CommandText = "DELETE FROM Proyecto WHERE nombreProyecto = '"+ proyecto + "'";
                int cantidad = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);    
            }

        }


        public List<string> get_tarea(string id)
        {
            int id_convertido = Convert.ToInt32(id);
            conexion = new SQLiteConnection(ruta);
            conexion.Open();

            string sql = $"SELECT * FROM Tareas WHERE idTarea = '{id}'";

            comando = new SQLiteCommand(sql, conexion);
            SQLiteDataReader data = comando.ExecuteReader();

            List<string> tarea = new List<string>();

            while (data.Read())
            {
                string id_tarea = data.GetInt32(0).ToString();
                tarea.Add(id_tarea);
                tarea.Add(data.GetString(1));
                tarea.Add(data.GetString(2));
                tarea.Add(data.GetString(3));
                tarea.Add(data.GetString(4));
                tarea.Add(data.GetString(5));
            }

            conexion.Close();
            return tarea;
        }
    }
}
