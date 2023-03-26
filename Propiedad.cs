using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    class Propiedad
    {
        int noCasa;
        string nit;
        int cuotaMantenimiento;

        public int NoCasa { get => noCasa; set => noCasa = value; }
        public string Nit { get => nit; set => nit = value; }
        public int CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
