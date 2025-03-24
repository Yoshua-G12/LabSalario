namespace LabSalario
{
    partial class FormEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsueldoxhora = new System.Windows.Forms.MaskedTextBox();
            this.txtnombreempleado = new System.Windows.Forms.TextBox();
            this.txtnoempleado = new System.Windows.Forms.NumericUpDown();
            this.btningresarasistencia = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Empleado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo x Hora:";
            // 
            // txtsueldoxhora
            // 
            this.txtsueldoxhora.Location = new System.Drawing.Point(197, 234);
            this.txtsueldoxhora.Mask = "999.99";
            this.txtsueldoxhora.Name = "txtsueldoxhora";
            this.txtsueldoxhora.Size = new System.Drawing.Size(100, 22);
            this.txtsueldoxhora.TabIndex = 3;
            // 
            // txtnombreempleado
            // 
            this.txtnombreempleado.Location = new System.Drawing.Point(197, 151);
            this.txtnombreempleado.Name = "txtnombreempleado";
            this.txtnombreempleado.Size = new System.Drawing.Size(100, 22);
            this.txtnombreempleado.TabIndex = 4;
            // 
            // txtnoempleado
            // 
            this.txtnoempleado.Location = new System.Drawing.Point(197, 71);
            this.txtnoempleado.Name = "txtnoempleado";
            this.txtnoempleado.Size = new System.Drawing.Size(100, 22);
            this.txtnoempleado.TabIndex = 5;
            // 
            // btningresarasistencia
            // 
            this.btningresarasistencia.Location = new System.Drawing.Point(636, 43);
            this.btningresarasistencia.Name = "btningresarasistencia";
            this.btningresarasistencia.Size = new System.Drawing.Size(148, 50);
            this.btningresarasistencia.TabIndex = 6;
            this.btningresarasistencia.Text = "Ingresar Asistencia";
            this.btningresarasistencia.UseVisualStyleBackColor = true;
            this.btningresarasistencia.Click += new System.EventHandler(this.btningresarasistencia_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(636, 401);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(148, 46);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.Text = "CERRAR";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(101, 317);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(148, 46);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(337, 203);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btningresarasistencia);
            this.Controls.Add(this.txtnoempleado);
            this.Controls.Add(this.txtnombreempleado);
            this.Controls.Add(this.txtsueldoxhora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleado";
            this.Text = "Formulario Asistencia";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnoempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtsueldoxhora;
        private System.Windows.Forms.TextBox txtnombreempleado;
        private System.Windows.Forms.NumericUpDown txtnoempleado;
        private System.Windows.Forms.Button btningresarasistencia;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

