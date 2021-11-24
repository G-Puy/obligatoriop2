using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obli_2_p2.Models
{
    public class UsuarioCliente : Usuario
    {
        public UsuarioCliente(string nombre, string apellido, string email, DateTime fechaNacimiento, string password, string nick) : base(nombre, apellido, email, fechaNacimiento, password, nick)
        {
            TipoUsuario = "cliente";
        }
       
    }
}
