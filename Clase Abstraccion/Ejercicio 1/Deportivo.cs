using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Deportivo:Auto,I_AFIP
    {
        public Deportivo(string patente):base(patente) 
        {
           
        }
        public override float CalcularCosto()
        {
            return 150f;
        }

        float I_AFIP.RetornarImpuesto()
        {
            return 50f;
        }
    }
}
