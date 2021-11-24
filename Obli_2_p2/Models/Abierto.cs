using System;
using System.Collections.Generic;
using System.Text;

namespace Obli_2_p2.Models
{
    public class Abierto : Lugar
    {
        
        public Abierto(string nombre, decimal mt2)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Mt2 = mt2;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Abierto abierto &&
                   Nombre == abierto.Nombre &&
                   Mt2 == abierto.Mt2;
        }


        //-------------------------------------------------------------------------
        //Verificamos si existe algún lugar abierto
        //-------------------------------------------------------------------------
        public static bool ExisteAbierto(Abierto ab, List<Lugar> lugares)
        {
            bool existe = false;
            foreach (Lugar item in lugares)
            {
                if (ab.Equals(item))
                {
                    existe = true;
                    ultimoId--;
                }
            }
            return existe;
        }

        public override string ToString()
        {
            return $"Lugar: {Nombre}\n" +
                $"Area mt2: {Mt2}\n";
        }
        public override double PrecioSegunLugar()
        {
            double Precio = Sistema.PrecioBase;
            if (Mt2 > 1000)
            {
                Precio += Precio * 0.10;
            }
            return Precio;
        }
    }
}
