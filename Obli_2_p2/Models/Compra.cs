using System;
using System.Collections.Generic;
using System.Text;

namespace Obli_2_p2.Models
{
    public class Compra
    {
        private static int ultimoId = 1;
        public int Id { get; set; }
        public Actividad ActividadComprada { get; set; } 
        public int CantEntradas { get; set; }
        public Usuario  Usuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public Estados Estado { get; set; }
        public double PrecioFinal { get; set; }

        public enum Estados
        {
           activa = 1,
           cancelada = 2
        }

        public Compra(Actividad actividadComprada, int cantEntradas, Usuario usuario, DateTime fechaCompra, double precioFinal)
        {
            Id = ultimoId;
            ultimoId++;
            ActividadComprada = actividadComprada;
            CantEntradas = cantEntradas;    
            Usuario = usuario;
            FechaCompra = fechaCompra;
            Estado = Estados.activa;
            PrecioFinal = precioFinal;
        }
        public override string ToString()
        {
            return $"Nombre de actividad comprada: {ActividadComprada.Nombre}\n" +
                   $"Cantidad de entradas compradas: {CantEntradas}\n" +
                   $"Adquiere: {Usuario.Nombre}\n" +
                   $"Fecha de compra: {FechaCompra}\n" +
                   $"Estado de la compra: {Estado}\n";
        }
        public double PrecioTotal()
        {
            double total = -1;
            double pa = ActividadComprada.PrecioActividad();
            total = pa * CantEntradas;
            return total;
        }
    }
}
