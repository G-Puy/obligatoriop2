using System;
using System.Collections.Generic;
using System.Text;

namespace Obli_2_p2.Models
{
    public abstract class Lugar
    {
        protected static int ultimoId = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Mt2 { get; set; }
        public bool Estado { get; set; }

       //Calcula el precio de la actividad mediante polimorfismo
        public abstract double PrecioSegunLugar();

        protected Lugar(string nombre, decimal mt2)
        {
           
            Nombre = nombre;
            Mt2 = mt2;
            Estado = true;
        }
        protected Lugar()
        {
        }
        public abstract override string ToString();
        
    }
}
