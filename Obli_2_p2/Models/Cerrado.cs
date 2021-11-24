using System;
using System.Collections.Generic;
using System.Text;

namespace Obli_2_p2.Models
{
    public class Cerrado : Lugar
    {
        public bool Accesibilidad { get; set; }
        public double Mantenimiento { get; set; }

        public Cerrado(string nombre, decimal mt2, bool accesibilidad, double mantenimiento)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Mt2 = mt2;
            Accesibilidad = accesibilidad;
            Mantenimiento = mantenimiento;
        }

        public override string ToString()
        {
            return $"Lugar: {Nombre}\n" +
                   $"Area mt2: {Mt2}\n" +
                   $"Accesibilidad: {Accesibilidad}\n" +
                   $"Mantenimiento: {Mantenimiento}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Cerrado cerrado &&
                   Nombre == cerrado.Nombre &&
                   Mt2 == cerrado.Mt2 &&
                   Accesibilidad == cerrado.Accesibilidad &&
                   Mantenimiento == cerrado.Mantenimiento;
        }

        //-------------------------------------------------------------------------
        //Verificamos si existe lugar cerrado
        //-------------------------------------------------------------------------
        public static bool ExisteCerrado(Cerrado cer, List<Lugar> lugares)
        {
            bool existe = false;
            foreach (Lugar item in lugares)
            {
                if (cer.Equals(item))
                {
                    existe = true;
                    ultimoId--;
                }
            }
            return existe;
        }



        public override double PrecioSegunLugar()
        {
            int aforo = Sistema.AforoMaximo;
            double Precio = Sistema.PrecioBase;

            if (aforo < 50 && aforo > 0)
            {
                Precio += Precio * 0.30;
            }
            else if (aforo > 50 && aforo < 70)
            {
                Precio += Precio * 0.15;
            }


            return Precio;
        }
    }
}
