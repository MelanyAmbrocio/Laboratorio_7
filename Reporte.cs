using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    class Reporte
    {
        string nombre;
        string apellido;
        int noCasa;
        int mantenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NoCasa { get => noCasa; set => noCasa = value; }
        public int Mantenimiento { get => mantenimiento; set => mantenimiento = value; }
    }
}
