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
    public partial class NuevaTarea : Form
    {
        public NuevaTarea()
        {
            InitializeComponent();


            BaseDatos db = new BaseDatos();
            List<string> datos = db.devolver_proyectos();

            foreach (string dato in datos)
            {
                comboBox1.Items.Add(dato);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCrearTarea_Click(object sender, EventArgs e)
        {
            string nombreProyecto;
            string nombreTarea = textBox1.Text.Trim();
            string descripccionTarea = textBox2.Text;
            string fechaInicio = dateTimePickerInicio.Value.Day.ToString();
            fechaInicio += "/" + dateTimePickerInicio.Value.Month.ToString();
            fechaInicio += "/" + dateTimePickerInicio.Value.Year.ToString();
            string fechaTermino = dateTimePicker1.Value.Day.ToString();
            fechaTermino += "/" + dateTimePicker1.Value.Month.ToString();
            fechaTermino += "/" + dateTimePicker1.Value.Year.ToString();

            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un proyecto");
            }
            else if(nombreTarea.Length >= 1 && descripccionTarea.Length >= 1)
            {
                nombreProyecto = comboBox1.Text;
                BaseDatos db = new BaseDatos();
                db.insertar_tarea(nombreTarea, descripccionTarea, fechaInicio, fechaTermino, nombreProyecto);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por Favor rellene todos los campos", "Error de Registro");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
