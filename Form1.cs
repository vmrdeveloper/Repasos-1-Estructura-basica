using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscripcionItla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            Estudiantes est = new Estudiantes();

            est.matricula = txtMatricula.Text;
            est.nombre = txtNombreE.Text;
            est.apellido = txtApellido.Text;
            est.carrera = txtCarrera.Text;
            MessageBox.Show("Estudiante agregado correctamente.");


        }

        private void btnGuardarA_Click(object sender, EventArgs e)
        {
            Asignaturas asg = new Asignaturas();

            asg.codigo = txtCodigo.Text;
            asg.nombre = txtNombreA.Text;
            MessageBox.Show("Asignatura guardada correctamente.");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Estudiantes est = new Estudiantes();
            Asignaturas asg = new Asignaturas();
            est.matricula = txtMatricula.Text;
            est.nombre = txtNombreE.Text;
            est.apellido = txtApellido.Text;
            est.carrera = txtCarrera.Text;
            asg.codigo = txtCodigo.Text;
            asg.nombre = txtNombreA.Text;

            contextMenuStrip1.Text = txtHorario.Text;
            contextMenuStrip1.Text = $"Matrícula\tEstudiante\tMateria\n";
            contextMenuStrip1.Text = $"{est.matricula}\t{est.nombre} {est.apellido}\t{asg.nombre}\n";

        }
    }
}
