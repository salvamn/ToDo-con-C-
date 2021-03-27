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
    public partial class AgregarProyecto : Form
    {
        public AgregarProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreProyecto = cajaAgregarProyecto.Text;

            if (nombreProyecto.Length >= 1)
            {
                BaseDatos db = new BaseDatos();
                db.insertar_proyecto(nombreProyecto);

                this.Close(); 
            }
            else
            {
                MessageBox.Show("Por Favor rellene el campo", "Error de Registro");
            }
        }
    }
}
