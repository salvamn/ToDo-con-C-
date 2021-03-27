using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BaseDatos db = new BaseDatos();
            foreach(string dato in db.devolver_proyectos())
            {
                listBoxDeProyectos.Items.Add(dato);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarProyecto agregarProyecto = new AgregarProyecto();
            agregarProyecto.ShowDialog();
   
            listBoxDeProyectos.Items.Clear();
            
            BaseDatos db = new BaseDatos();
            List<string> datos = db.devolver_proyectos();
            foreach (string dato in datos)
            {
                listBoxDeProyectos.Items.Add(dato);
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaTarea nuevaTarea = new NuevaTarea();
            nuevaTarea.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxDeProyectos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string seleccion = listBoxDeProyectos.SelectedItem.ToString();
            BaseDatos db = new BaseDatos();
            List<Array> lista = db.devolver_tareas(seleccion);

            if(listViewDeTareas.Items.Count == 0)
            {
                foreach (Array dato in lista)
                {
                    string id = dato.GetValue(0).ToString();
                    ListViewItem agregar = new ListViewItem(id);
                    agregar.SubItems.Add(dato.GetValue(1).ToString());
                    agregar.SubItems.Add(dato.GetValue(2).ToString());
                    agregar.SubItems.Add(dato.GetValue(3).ToString());
                    agregar.SubItems.Add(dato.GetValue(4).ToString());
                    agregar.SubItems.Add(dato.GetValue(5).ToString());
                    listViewDeTareas.Items.Add(agregar);
                }
            }
            else
            {
                listViewDeTareas.Items.Clear();
                foreach (Array dato in lista)
                {
                    string id = dato.GetValue(0).ToString();
                    ListViewItem agregar = new ListViewItem(id);
                    agregar.SubItems.Add(dato.GetValue(1).ToString());
                    agregar.SubItems.Add(dato.GetValue(2).ToString());
                    agregar.SubItems.Add(dato.GetValue(3).ToString());
                    agregar.SubItems.Add(dato.GetValue(4).ToString());
                    agregar.SubItems.Add(dato.GetValue(5).ToString());
                    listViewDeTareas.Items.Add(agregar);
                }
            }

        }

        /*
         - Crear boton actualizar tarea y dar funcionalidad
         - Crear boton eliminar tarea y dar funcionalidad
         */

        private void listViewDeTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarProyecto_Click(object sender, EventArgs e)
        {
            if(listBoxDeProyectos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un proyecto", "Error de seleccion");
            }
            else
            {
                string seleccion = listBoxDeProyectos.SelectedItem.ToString();
                BaseDatos db = new BaseDatos();
                List<Array> lista = db.devolver_tareas(seleccion);

                if (listViewDeTareas.Items.Count == 0)
                {
                    foreach (Array dato in lista)
                    {
                        string id = dato.GetValue(0).ToString();
                        ListViewItem agregar = new ListViewItem(id);
                        agregar.SubItems.Add(dato.GetValue(1).ToString());
                        agregar.SubItems.Add(dato.GetValue(2).ToString());
                        agregar.SubItems.Add(dato.GetValue(3).ToString());
                        agregar.SubItems.Add(dato.GetValue(4).ToString());
                        agregar.SubItems.Add(dato.GetValue(5).ToString());
                        listViewDeTareas.Items.Add(agregar);
                    }
                }
                else
                {
                    listViewDeTareas.Items.Clear();
                    foreach (Array dato in lista)
                    {
                        string id = dato.GetValue(0).ToString();
                        ListViewItem agregar = new ListViewItem(id);
                        agregar.SubItems.Add(dato.GetValue(1).ToString());
                        agregar.SubItems.Add(dato.GetValue(2).ToString());
                        agregar.SubItems.Add(dato.GetValue(3).ToString());
                        agregar.SubItems.Add(dato.GetValue(4).ToString());
                        agregar.SubItems.Add(dato.GetValue(5).ToString());
                        listViewDeTareas.Items.Add(agregar);
                    }
                }
            }
            
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            if(listBoxDeProyectos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proyecto", "Error de seleccion");
            }
            else
            {
                string proyectoEliminar = listBoxDeProyectos.SelectedItem.ToString();
                DialogResult opcion = MessageBox.Show(
                    $"¿ Desea eliminar el proyecto: {proyectoEliminar}",
                    "Eliminar Proyecto",
                    MessageBoxButtons.YesNo);

                if(opcion == DialogResult.Yes)
                {
                    BaseDatos db = new BaseDatos();
                    db.eliminar(proyectoEliminar);
                    MessageBox.Show("Proyecto eliminado con exito", "Eliminar Proyecto");

                    listBoxDeProyectos.Items.Clear();

                    List<string> datos = db.devolver_proyectos();
                    foreach (string dato in datos)
                    {
                        listBoxDeProyectos.Items.Add(dato);
                    }

                }
                else if(opcion == DialogResult.No){}
            }
        }


        private void btnMostrarTarea_Click(object sender, EventArgs e)
        {
            MostrarTarea mostrarTarea = new MostrarTarea();
            BaseDatos db = new BaseDatos();

            try
            {
                string id = listViewDeTareas.SelectedItems[0].SubItems[0].Text;
                List<string> datos = db.get_tarea(id);

                mostrarTarea.label1.Text = datos[1];
                mostrarTarea.cajaDescripcion.Text = datos[2];

                mostrarTarea.ShowDialog();
            }
            catch(Exception error)
            {
                MessageBox.Show($"Por favor selecione una tarea\n{error.Message}", "Error de Tarea");
            }
        }
    }
}
