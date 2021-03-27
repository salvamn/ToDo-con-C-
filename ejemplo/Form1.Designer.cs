
using System;
using System.Windows.Forms;

namespace ejemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxDeProyectos = new System.Windows.Forms.ListBox();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnMostrarProyecto = new System.Windows.Forms.Button();
            this.listViewDeTareas = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proyecto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarTarea = new System.Windows.Forms.Button();
            this.btnActualizarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nuevo Proyecto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxDeProyectos
            // 
            this.listBoxDeProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.listBoxDeProyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDeProyectos.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDeProyectos.ForeColor = System.Drawing.Color.White;
            this.listBoxDeProyectos.FormattingEnabled = true;
            this.listBoxDeProyectos.ItemHeight = 23;
            this.listBoxDeProyectos.Location = new System.Drawing.Point(12, 121);
            this.listBoxDeProyectos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxDeProyectos.Name = "listBoxDeProyectos";
            this.listBoxDeProyectos.Size = new System.Drawing.Size(310, 485);
            this.listBoxDeProyectos.TabIndex = 3;
            this.listBoxDeProyectos.SelectedIndexChanged += new System.EventHandler(this.listBoxDeProyectos_SelectedIndexChanged);
            this.listBoxDeProyectos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDeProyectos_MouseDoubleClick);
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNuevaTarea.FlatAppearance.BorderSize = 0;
            this.btnNuevaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTarea.Location = new System.Drawing.Point(168, 13);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(154, 47);
            this.btnNuevaTarea.TabIndex = 5;
            this.btnNuevaTarea.Text = "Nueva Tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = false;
            this.btnNuevaTarea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(168, 67);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(154, 47);
            this.btnEliminarProyecto.TabIndex = 6;
            this.btnEliminarProyecto.Text = "Eliminar Proyecto";
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnMostrarProyecto
            // 
            this.btnMostrarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMostrarProyecto.FlatAppearance.BorderSize = 0;
            this.btnMostrarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProyecto.Location = new System.Drawing.Point(12, 67);
            this.btnMostrarProyecto.Name = "btnMostrarProyecto";
            this.btnMostrarProyecto.Size = new System.Drawing.Size(150, 47);
            this.btnMostrarProyecto.TabIndex = 7;
            this.btnMostrarProyecto.Text = "Mostrar Proyecto";
            this.btnMostrarProyecto.UseVisualStyleBackColor = false;
            this.btnMostrarProyecto.Click += new System.EventHandler(this.btnMostrarProyecto_Click);
            // 
            // listViewDeTareas
            // 
            this.listViewDeTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.listViewDeTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDeTareas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.tarea,
            this.descripcion,
            this.fechaInicio,
            this.fechaFin,
            this.proyecto});
            this.listViewDeTareas.ForeColor = System.Drawing.Color.White;
            this.listViewDeTareas.FullRowSelect = true;
            this.listViewDeTareas.HideSelection = false;
            this.listViewDeTareas.Location = new System.Drawing.Point(329, 122);
            this.listViewDeTareas.Name = "listViewDeTareas";
            this.listViewDeTareas.Size = new System.Drawing.Size(551, 481);
            this.listViewDeTareas.TabIndex = 8;
            this.listViewDeTareas.UseCompatibleStateImageBehavior = false;
            this.listViewDeTareas.View = System.Windows.Forms.View.Details;
            this.listViewDeTareas.SelectedIndexChanged += new System.EventHandler(this.listViewDeTareas_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Tag = "";
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // tarea
            // 
            this.tarea.Text = "TAREA";
            // 
            // descripcion
            // 
            this.descripcion.Text = "DESCRIPCION";
            this.descripcion.Width = 130;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Text = "FECHA INICIO";
            this.fechaInicio.Width = 120;
            // 
            // fechaFin
            // 
            this.fechaFin.Text = "FECHA FIN";
            this.fechaFin.Width = 120;
            // 
            // proyecto
            // 
            this.proyecto.Text = "PROYECTO";
            this.proyecto.Width = 100;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(758, 67);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 47);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarTarea
            // 
            this.btnMostrarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMostrarTarea.FlatAppearance.BorderSize = 0;
            this.btnMostrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTarea.Location = new System.Drawing.Point(328, 67);
            this.btnMostrarTarea.Name = "btnMostrarTarea";
            this.btnMostrarTarea.Size = new System.Drawing.Size(136, 47);
            this.btnMostrarTarea.TabIndex = 10;
            this.btnMostrarTarea.Text = "Mostrar Tarea";
            this.btnMostrarTarea.UseVisualStyleBackColor = false;
            this.btnMostrarTarea.Click += new System.EventHandler(this.btnMostrarTarea_Click);
            // 
            // btnActualizarTarea
            // 
            this.btnActualizarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnActualizarTarea.FlatAppearance.BorderSize = 0;
            this.btnActualizarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTarea.Location = new System.Drawing.Point(470, 67);
            this.btnActualizarTarea.Name = "btnActualizarTarea";
            this.btnActualizarTarea.Size = new System.Drawing.Size(145, 47);
            this.btnActualizarTarea.TabIndex = 11;
            this.btnActualizarTarea.Text = "Actualizar Tarea";
            this.btnActualizarTarea.UseVisualStyleBackColor = false;
            this.btnActualizarTarea.Visible = false;
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEliminarTarea.FlatAppearance.BorderSize = 0;
            this.btnEliminarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarea.Location = new System.Drawing.Point(621, 67);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(131, 47);
            this.btnEliminarTarea.TabIndex = 12;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de Proyectos";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(892, 615);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnActualizarTarea);
            this.Controls.Add(this.btnMostrarTarea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listViewDeTareas);
            this.Controls.Add(this.btnMostrarProyecto);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.btnNuevaTarea);
            this.Controls.Add(this.listBoxDeProyectos);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBoxDeProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        #endregion
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListBox listBoxDeProyectos;
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Button btnMostrarProyecto;
        public System.Windows.Forms.ListView listViewDeTareas;
        private System.Windows.Forms.Button btnSalir;
        private ColumnHeader id;
        private ColumnHeader tarea;
        private ColumnHeader descripcion;
        private ColumnHeader fechaInicio;
        private ColumnHeader fechaFin;
        private ColumnHeader proyecto;
        private Button btnMostrarTarea;
        private Button btnActualizarTarea;
        private Button btnEliminarTarea;
        private Label label1;
    }
}

