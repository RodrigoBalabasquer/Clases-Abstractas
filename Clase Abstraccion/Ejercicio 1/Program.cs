using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main()
        {
            Familiar AutoFamiliar = new Familiar("AGW452");
            Deportivo AutoDeportivo = new Deportivo("HRF457");
            Avion UnAvion = new Avion("HGE756");
            Carreta UnaCarreta = new Carreta("TBD475");
            List<Vehiculo> Lista = new List<Vehiculo>();
            List<I_AFIP> ListaIafir = new List<I_AFIP>();
            Lista.Add(AutoDeportivo);
            Lista.Add(AutoFamiliar);
            Lista.Add(UnAvion);
            Lista.Add(UnaCarreta);
            ListaIafir.Add(AutoDeportivo);
            ListaIafir.Add(UnAvion);
            foreach (Vehiculo item in Lista)
            {
                Console.WriteLine(item.CalcularCosto());
            }
            foreach  (I_AFIP item in ListaIafir)
            {
                 Console.WriteLine(item.RetornarImpuesto());
            }
            Console.ReadKey();
        }
    }
}
