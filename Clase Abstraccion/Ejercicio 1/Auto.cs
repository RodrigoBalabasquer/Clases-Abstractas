using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public abstract class Auto:Vehiculo
    {
        public int _cantidadDePuertas;
        public Auto(string patente):base(patente) 
        {
           
        }
        //Utilizacion de metodo virtual
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Cantidad de puertas: " + this._cantidadDePuertas);
            return sb.ToString();
        }
        
    }
}
