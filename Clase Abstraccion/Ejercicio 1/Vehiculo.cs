using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public abstract class Vehiculo
    {
        public string _patente;
        public Vehiculo(string patente) 
        {
            this._patente = patente;
        }
        public override string ToString()
        {
            return this._patente;
        }
        //Creacion de metodo virtual
        public virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this._patente);
            return sb.ToString();
        }
        //Solo podemos escribir la implementacion del metodo
        public abstract float CalcularCosto();
    }
}
