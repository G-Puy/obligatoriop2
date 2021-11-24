using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Obli_2_p2.Models
{
    public abstract class Usuario : IComparable<Usuario>
    {
        protected static int ultimoId = 1;
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Password { get; set; }
        public string Nick { get; set; }
        public string TipoUsuario { get; set; }
        public bool Estado { get; set; }
        protected Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento, string password, string nick)
        {
            idUsuario = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Password = password;
            Nick = nick;
            Estado = true;
        }


        public override string ToString()
        {
            return $"Nombre {Nombre}\n" +
                   $"Apellido {Apellido}\n" +
                   $"Email: {Email}\n" +
                   $"Fecha de nacimiento: {FechaNacimiento}\n";
        }

        public int CompareTo([AllowNull] Usuario other)
        {
            if (this.Nombre.CompareTo(other.Nombre) > 0)
            {
                return 1;
            }
            else if (this.Nombre.CompareTo(other.Nombre) < 0)
            {
                return -1;
            }
            else
            {
                if (this.Apellido.CompareTo(other.Apellido) > 0)
                {
                    return 1;
                }
                else if (this.Apellido.CompareTo(other.Apellido) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
