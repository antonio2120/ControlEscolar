namespace controlEscolar
{
    partial class fmAlumnoConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btAlumnoEditar = new System.Windows.Forms.Button();
            this.btAlumnoEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAlumnos.Location = new System.Drawing.Point(24, 67);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1030, 334);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            this.dgvAlumnos.DoubleClick += new System.EventHandler(this.dgvAlumnos_DoubleClick);
            // 
            // btAlumnoEditar
            // 
            this.btAlumnoEditar.Location = new System.Drawing.Point(733, 415);
            this.btAlumnoEditar.Name = "btAlumnoEditar";
            this.btAlumnoEditar.Size = new System.Drawing.Size(152, 41);
            this.btAlumnoEditar.TabIndex = 2;
            this.btAlumnoEditar.Text = "Editar";
            this.btAlumnoEditar.UseVisualStyleBackColor = true;
            this.btAlumnoEditar.Click += new System.EventHandler(this.Editar);
            // 
            // btAlumnoEliminar
            // 
            this.btAlumnoEliminar.Location = new System.Drawing.Point(902, 415);
            this.btAlumnoEliminar.Name = "btAlumnoEliminar";
            this.btAlumnoEliminar.Size = new System.Drawing.Size(152, 41);
            this.btAlumnoEliminar.TabIndex = 3;
            this.btAlumnoEliminar.Text = "Eliminar";
            this.btAlumnoEliminar.UseVisualStyleBackColor = true;
            this.btAlumnoEliminar.Click += new System.EventHandler(this.btAlumnoEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ALUMNOS REGISTRADOS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar";
            // 
            // fmAlumnoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAlumnoEliminar);
            this.Controls.Add(this.btAlumnoEditar);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "fmAlumnoConsulta";
            this.Text = "Consulta Alumno";
            this.Load += new System.EventHandler(this.fmAlumnoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btAlumnoEditar;
        private System.Windows.Forms.Button btAlumnoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}