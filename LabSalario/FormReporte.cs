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
    public partial class FormReporte : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencia = new List<Asistencia>();
        List<ReporteSueldo> reporteSueldos = new List<ReporteSueldo>(); 
        public FormReporte()
        {
            InitializeComponent();
        }
        private void CargaEmpleados()
        {
            EmpleadoArchivo empleadoarchivo = new EmpleadoArchivo();
            empleados = empleadoarchivo.Leer("../../Empleados.json");
        }
        private void CargaAsistencia()
        {

        }
        private void FormReporte_Load(object sender, EventArgs e)
        {

        }

        private void btnmostrarreporte_Click(object sender, EventArgs e)
        {
            foreach (var empleado in empleados)
            {
                foreach(var asistencia in asistencia)
                {
                    if(empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        ReporteSueldo reporte = new ReporteSueldo();
                        reporte.Nombre = empleado.Nombre;
                        reporte.Mes = asistencia.Mes.ToString();
                        reporte.SueldoTotal = empleado.sueldoxhora * asistencia.horasMes;
                        reporteSueldos.Add(reporte);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
