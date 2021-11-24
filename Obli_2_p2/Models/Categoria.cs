using System;
using System.Collections.Generic;
using System.Text;

namespace Obli_2_p2.Models
{
    public class Categoria
    {
        private static int ultimoId = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Categoria(string nombre, string descripcion)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = true;
        }
        
        public override string ToString()
        {
            return $"Nombre: {Nombre} Descripcion: {Descripcion}\n";     
        }

        public override bool Equals(object obj)
        {
            return obj is Categoria categoria &&
                   Nombre == categoria.Nombre &&
                   Descripcion == categoria.Descripcion;
        }

        //-------------------------------------------------------------------------
        //Verificamos que exista la categoría
        //-------------------------------------------------------------------------
        public static bool ExisteCategoria(Categoria cat, List<Categoria> categorias)
        {
            bool validado = false;
            foreach (Categoria item in categorias)
            {
                if (cat.Equals(item))
                {
                    validado = true;
                    ultimoId--;
                }
            }
            return validado;
        }
    }
}
