using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSalario
{
    public partial class FormEmpleado : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public FormEmpleado()
        {
            InitializeComponent();
        }
         

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresarasistencia_Click(object sender, EventArgs e)
        {
            Formulario_Asistencia formulario_Asistencia= new Formulario_Asistencia();
            formulario_Asistencia.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //1)Crear el objeto empleado
            Empleado empleado = new Empleado();
            //2) Ingresarle datos al objeto empleado
            empleado.NoEmpleado = Convert.ToInt16(txtnoempleado.Text);
            empleado.Nombre = txtnombreempleado.Text;
            empleado.sueldoxhora = Convert.ToDecimal(txtsueldoxhora.Text);
            //3) La lista se declaro global
            //4) Insertar el objeto a la lista
            empleados.Add(empleado);
            //5) Crear un objeto empleado archivo
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            //6) Llamar el metodo grabar
            empleadoArchivo.Guardar("../../Empleados.json", empleados);
            Mostrar();
        }
        private void Mostrar()
        {
            EmpleadoArchivo empleadoarchivo = new EmpleadoArchivo();
            empleados = empleadoarchivo.Leer("../../Empleados.json");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
            dataGridView1.Refresh();
        }
        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();    
            formReporte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
