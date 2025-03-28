namespace LabSalario
{
    partial class Formulario_Asistencia
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(200, 340);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(227, 69);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar Asistencia";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mes";
            // 
            // numericMes
            // 
            this.numericMes.Location = new System.Drawing.Point(200, 230);
            this.numericMes.Margin = new System.Windows.Forms.Padding(4);
            this.numericMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(92, 22);
            this.numericMes.TabIndex = 12;
            this.numericMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericHoras
            // 
            this.numericHoras.Location = new System.Drawing.Point(200, 131);
            this.numericHoras.Margin = new System.Windows.Forms.Padding(4);
            this.numericHoras.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(92, 22);
            this.numericHoras.TabIndex = 11;
            this.numericHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Horas Trabajadas";
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(200, 29);
            this.comboBoxEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(456, 24);
            this.comboBoxEmpleados.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empleado";
            // 
            // Formulario_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericMes);
            this.Controls.Add(this.numericHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Formulario_Asistencia";
            this.Text = "Formulario_Asistencia";
            this.Load += new System.EventHandler(this.Formulario_Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.NumericUpDown numericHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Label label1;
    }
}