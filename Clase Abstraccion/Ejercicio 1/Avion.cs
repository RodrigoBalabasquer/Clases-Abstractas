using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Avion:Vehiculo,I_AFIP
    {   
        public Avion(string patente):base(patente) 
        {
           
        }
        public override float CalcularCosto()
        {
            return 1500f;
        }

        float I_AFIP.RetornarImpuesto()
        {
            return 500f;
        }
    }
}
