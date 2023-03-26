using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Reporte> reportes = new List<Reporte>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerPropiedades();
            LeerPropietarios();

            Mostrar();
        }

        private void LeerPropietarios()
        {

            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();

                propietario.Nit = reader.ReadLine();
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();

                propietarios.Add(propietario);
            }
            reader.Close();
        }

        private void LeerPropiedades()
        {

            FileStream stream = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();

                propiedad.NoCasa = Convert.ToInt32(reader.ReadLine());
                propiedad.Nit = reader.ReadLine();
                propiedad.CuotaMantenimiento = Convert.ToInt32(reader.ReadLine());

                propiedades.Add(propiedad);
            }
            reader.Close();
        }
        public void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }

        private void btnOrdenarAsc_Click(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(c => c.Mantenimiento).ToList();
            Mostrar();
        }

        private void btnOrdenarDesc_Click(object sender, EventArgs e)
        {
            reportes = reportes.OrderByDescending(c => c.Mantenimiento).ToList();
            Mostrar();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propiedades.Count; i++)
            {
                Reporte reporte = new Reporte();

                for (int j = 0; j < propietarios.Count; j++)
                {
                    if (propiedades[i].Nit == propietarios[j].Nit)
                    {
                        reporte.Nombre = propietarios[j].Nombre;
                        reporte.Apellido = propietarios[j].Apellido;
                        reporte.NoCasa = propiedades[i].NoCasa;
                        reporte.Mantenimiento = propiedades[i].CuotaMantenimiento;
                    }
                }
                reportes.Add(reporte);
            }
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mayor = reportes.Max(c => c.Mantenimiento);
            int menor = reportes.Min(c => c.Mantenimiento);

            Reporte m = reportes.OrderByDescending(r => r.Mantenimiento).First();


            lblMayorc.Text = mayor.ToString();
            lblMenorC.Text = menor.ToString();
            lblPropietarioC.Text = m.ToString();


        }
    }
}
