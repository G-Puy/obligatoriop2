using System;
using System.Collections.Generic;
using System.Text;

namespace Obli_2_p2.Models
{
    public class Actividad
    {
        private static int ultimoId = 1;
        public int idActi { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime FechaYHora { get; set; }
        public Lugar Lugar { get; set; }
        public double PrecioBase { get; set; }
        public EdadMinima MinimaEdad { get; set; }
        public int CantidadMG { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public enum EdadMinima
        {
            p = 1,
            c13 = 2,
            c16 = 3,
            c18 = 4,
            unknown = 5
        }

        public Actividad(Categoria categoria, DateTime fechaYHora, Lugar lugar, EdadMinima minimaEdad, int cantidadMG, string nombre)
        {
            idActi = ultimoId;
            ultimoId++;
            Categoria = categoria;
            FechaYHora = fechaYHora;
            Lugar = lugar;
            PrecioBase = Sistema.PrecioBase;
            MinimaEdad = minimaEdad;
            CantidadMG = cantidadMG;
            Nombre = nombre;
            Estado = true;
        }

        // recibe un decimal de lugar que se considera un descuento para asi multiplicarlo por el precio base y obtener el precio final 
        
        public override string ToString()
        {
            return $"Categoria: {Categoria}" +
                   $"Fecha y hora: {FechaYHora}\n" +
                   $"Lugar actividad: {Lugar}" +
                   $"Precio base: {PrecioBase}\n" +
                   $"Categoría edad: {MinimaEdad}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Actividad actividad &&
                   EqualityComparer<Categoria>.Default.Equals(Categoria, actividad.Categoria) &&
                   FechaYHora == actividad.FechaYHora &&
                   EqualityComparer<Lugar>.Default.Equals(Lugar, actividad.Lugar) &&
                   PrecioBase == actividad.PrecioBase &&
                   MinimaEdad == actividad.MinimaEdad &&
                   CantidadMG == actividad.CantidadMG &&
                   Nombre == actividad.Nombre;
        }


        //-------------------------------------------------------------------------
        //Verificamos que exista una actividad
        //-------------------------------------------------------------------------
        public static bool ExisteActividad(Actividad act, List<Actividad> actividades)
        {
            bool validado = false;
            foreach (Actividad item in actividades)
            {
                if (act.Equals(item))
                {
                    validado = true;
                }
            }
            return validado;
        }


        //Calcula el precio final de cada actividad
        public double PrecioActividad()
        {
            return Lugar.PrecioSegunLugar();
        }


       
    }
}
