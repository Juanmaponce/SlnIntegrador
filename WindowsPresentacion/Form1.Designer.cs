namespace WindowsPresentacion
{
    partial class Form1
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
            this.btnMedicos = new System.Windows.Forms.Button();
            this.dataMedicoYPacientes = new System.Windows.Forms.DataGridView();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClinicos = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnEdad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedicoYPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(38, 37);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(181, 23);
            this.btnMedicos.TabIndex = 0;
            this.btnMedicos.Text = "Mostrar Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // dataMedicoYPacientes
            // 
            this.dataMedicoYPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMedicoYPacientes.Location = new System.Drawing.Point(38, 131);
            this.dataMedicoYPacientes.Name = "dataMedicoYPacientes";
            this.dataMedicoYPacientes.Size = new System.Drawing.Size(181, 260);
            this.dataMedicoYPacientes.TabIndex = 1;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(38, 83);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(181, 23);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Mostrar Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(272, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 264);
            this.listBox1.TabIndex = 3;
            // 
            // btnClinicos
            // 
            this.btnClinicos.Location = new System.Drawing.Point(272, 36);
            this.btnClinicos.Name = "btnClinicos";
            this.btnClinicos.Size = new System.Drawing.Size(145, 23);
            this.btnClinicos.TabIndex = 4;
            this.btnClinicos.Text = "Clinicos";
            this.btnClinicos.UseVisualStyleBackColor = true;
            this.btnClinicos.Click += new System.EventHandler(this.btnClinicos_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Location = new System.Drawing.Point(272, 83);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(145, 23);
            this.btnHabitaciones.TabIndex = 5;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnEdad
            // 
            this.btnEdad.Location = new System.Drawing.Point(495, 35);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(121, 23);
            this.btnEdad.TabIndex = 6;
            this.btnEdad.Text = "Edad Paciente";
            this.btnEdad.UseVisualStyleBackColor = true;
            this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdad);
            this.Controls.Add(this.btnHabitaciones);
            this.Controls.Add(this.btnClinicos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.dataMedicoYPacientes);
            this.Controls.Add(this.btnMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataMedicoYPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.DataGridView dataMedicoYPacientes;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClinicos;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnEdad;
    }
}

