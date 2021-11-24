using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Obli_2_p2.Models.Actividad;

namespace Obli_2_p2.Models
{
    public class Sistema
    {
        public static int AforoMaximo { get; set; }
        public static double PrecioBase { get; set; }

        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Compra> Compras = new List<Compra>();
        public List<Actividad> Actividades = new List<Actividad>();
        public List<Categoria> Categorias = new List<Categoria>();
        public List<Lugar> Lugares = new List<Lugar>();

        //Constructor sistema
        private Sistema()
        {
            AforoMaximo = 100;
            PrecioBase = 1500;
            Precarga();
        }
        //Singleton
        private static Sistema instancia = null;
        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }

        public List<Compra> GetComprasUsuario(int? id)
        {
            List<Compra> ComprasHechas = new List<Compra>();
            foreach (Compra c in Compras)
            {
                if (c.Usuario.idUsuario.Equals(id) && c.Estado == Compra.Estados.activa)
                {
                    ComprasHechas.Add(c);
                }
            }
            return ComprasHechas;
        }

        public List<Actividad> GetActividades()
        {
            return Actividades;
        }


        //Busca y devuelve una actividad  11-11-2021 Hora: 15:12 pm
        public Actividad GetActividad(int id)
        {
            Actividad buscada = null;
            foreach (Actividad act in Actividades)
            {
                if (act.idActi.Equals(id))
                {
                    buscada = act;
                }

            }
            return buscada;
        }

        //-------------------------------------------------------------------------------
        //Altas verificando que no se repitan instancias (c/u con sus respectivos existe)
        //-------------------------------------------------------------------------------

        public Actividad AltaActividad(Categoria categoria, DateTime fechaYHora, Lugar lugar, EdadMinima minimaEdad, int cantidadMG, string nombre)
        {

            Actividad nuevaActividad = null;
            if (categoria != null && lugar != null && fechaYHora != null && minimaEdad != EdadMinima.unknown && nombre != "" && cantidadMG >= 0)
            {
                nuevaActividad = new Actividad(categoria, fechaYHora, lugar, minimaEdad, cantidadMG, nombre);
                if (!Actividad.ExisteActividad(nuevaActividad, GetActividades()))
                {
                    Actividades.Add(nuevaActividad);
                }
            }
            return nuevaActividad;
        }



        public List<Categoria> GetCategorias()
        {
                return Categorias;
        }
        public Categoria AltaCategoria(string nombre, string descripcion)
        {
            Categoria nuevaCategoria = null;
            if (nombre != "" && descripcion != "")
            {
                nuevaCategoria = new Categoria(nombre, descripcion);
                if (Categoria.ExisteCategoria(nuevaCategoria, GetCategorias()) == false)
                {
                    Categorias.Add(nuevaCategoria);
                }
            }
            return nuevaCategoria;
        }



        public List<Lugar> GetLugares()
        {
            return Lugares;
        }
        public Abierto AltaLugarAbierto(string nombre, decimal mt2)
        {
            Abierto nuevoAbierto = null;
            if (nombre != null && mt2 > 0)
            {
                nuevoAbierto = new Abierto(nombre, mt2);
                if (Abierto.ExisteAbierto(nuevoAbierto, GetLugares()) == false)
                {
                    Lugares.Add(nuevoAbierto);
                }
            }
            return nuevoAbierto;
        }

        public double PrecioTotal(List<Compra> compras)
        {
            double res = 0;
            foreach (Compra c in compras)
            {
             res+=   c.PrecioFinal;
            }
            return res;
            
        }

        public List<Compra> GetComprasFechas(DateTime f1, DateTime f2)
        {
            List<Compra> res = new List<Compra>();
            if (f1 != null && f2 != null && f1 != f2)
            {
                if (f1 > f2)
                {
                    DateTime aux = f1;
                    f1 = f2;
                    f2 = aux;
                }
                foreach (Compra c in Compras)
                {
                    if (c.FechaCompra > f1 && c.FechaCompra < f2)
                    {
                        res.Add(c);
                    }
                }
            }
            return res;
        }

        public Cerrado AltaLugarCerrado(string nombre, decimal mt2, bool accesibilidad, double mantenimiento)
        {
            Cerrado nuevoCerrado = null;
            if (nombre != "" && mt2 > 0 && accesibilidad != null && mantenimiento >= 0)
            {
                nuevoCerrado = new Cerrado(nombre, mt2, accesibilidad, mantenimiento);
                if (!Cerrado.ExisteCerrado(nuevoCerrado, GetLugares()) == false)
                {
                    Lugares.Add(nuevoCerrado);
                }
            }
            return nuevoCerrado;
        }

        //-------------------------------------------------------------------------
        //Lista las actividades entre dos fechas
        //-------------------------------------------------------------------------
        public List<Actividad> ListarActFecha(DateTime f1, DateTime f2)
        {
            List<Actividad> actEntreFechas = new List<Actividad>();
            if (f1 != null && f2 != null && f1 != f2)
            {
                if (f1 > f2)
                {
                    DateTime aux = f1;
                    f1 = f2;
                    f2 = aux;
                }
                foreach (Actividad a in GetActividades())
                {
                    if (a.FechaYHora > f1 && a.FechaYHora < f2)
                    {
                        actEntreFechas.Add(a);
                    }
                }
            }
            return actEntreFechas;
        }

        //-------------------------------------------------------------------------
        //Lista las actividades aptas todo público
        //-------------------------------------------------------------------------

        public List<Actividad> ListarEspectaculoTodoPublico()
        {
            List<Actividad> actividadesTodoPublico = new List<Actividad>();
            foreach (Actividad a in GetActividades())
            {
                if (a.MinimaEdad == EdadMinima.p)
                {
                    actividadesTodoPublico.Add(a);
                }
            }
            return actividadesTodoPublico;
        }

        //-------------------------------------------------------------------------
        //Verificamos que el aforo cumpla los requerimientos, y luego en 
        // cambiarAforo realizamos el cambio del mismo
        //-------------------------------------------------------------------------


        public bool VerificarAforo(int aforo)
        {
            bool ret = false;
            if (!CambiarAforo(aforo))
            {
                while (aforo < 0 || aforo > 100)
                {
                    Console.WriteLine("Ingrese un valor mayor a 0 y menor a 100");
                    aforo = Int32.Parse(Console.ReadLine());
                }
                ret = true;
            }
            return ret;
        }
        public bool CambiarAforo(int aforo)
        {
            bool ret = false;
            if (aforo > 0 && aforo <= 100)
            {
                AforoMaximo = aforo;
                ret = true;
            }
            return ret;
        }


        //-------------------------------------------------------------------------
        //Idem Cambio de aforo
        //-------------------------------------------------------------------------

        public bool CambiarPrecioBase(double precio)
        {

            bool ret = false;
            if (precio > 0 && precio != PrecioBase)
            {
                PrecioBase = precio;
                ret = true;
            }

            return ret;

        }
        public bool VerificarBase(double precio)
        {
            bool ret = false;
            if (!CambiarPrecioBase(precio))
            {
                while (precio < 0 && !ret)
                {
                    Console.WriteLine("Ingrese un valor mayor a 0");
                    precio = Double.Parse(Console.ReadLine());
                }
                ret = true;
            }
            return ret;
        }

        //-------------------------------------------------------------------------
        //Verifica que el valor ingresado sea un int
        //-------------------------------------------------------------------------

        public bool VerificacionInt(int valor)
        {
            bool bandera = false;
            while (!bandera)
            {
                try
                {
                    Console.WriteLine("Ingrese un valor numérico válido");
                    valor = Int32.Parse(Console.ReadLine());
                    if (valor > 0)
                        bandera = true;
                }
                catch { }
            }
            return bandera;
        }

        //-------------------------------------------------------------------------
        //TomaDeFechas, TOMA NUEVAMENTE LOS DATOS DEL USUARIO DENTRO DEL CATCH.
        //Recibe un int unicamente para saber de qué fecha se trata.
        //Devuelve un DateTime al program (VALIDO).
        //No va a salir de la funcion hasta que se pueda devolver un DateTime Valido si o si.
        //-------------------------------------------------------------------------
        public DateTime TomaDeFechas(int contador)
        {
            DateTime nuevaFecha = DateTime.Now;
            bool bandera = false;
            while (!bandera)
            {
                Console.WriteLine($"Ingrese fecha {contador}");
                string fecha = Console.ReadLine();

                if (VerficiarDateTime(fecha))
                {
                    nuevaFecha = DateTime.Parse(fecha);

                    bandera = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor de fecha correcto, vamos usted puede");
                }
            }
            return nuevaFecha;
        }

        //-------------------------------------------------------------------------
        //VerificarDateTime VERIFICA DENTRO DE LA FUNCION TomaDeDatosDos
        //Recibe un String, Desde TomaDeDatosDos.
        //-------------------------------------------------------------------------
        public bool VerficiarDateTime(string fecha)
        {
            DateTime valor;
            bool bandera = false;
            try
            {
                valor = DateTime.Parse(fecha);
                bandera = true;
            }
            catch (Exception)
            {
            }
            return bandera;

        }
        //---------------------------------------------------------------------------------------------------------
        //------------------------------------------------USUARIO-------------------------------------------------
        //---------------------------------------------------------------------------------------------------------
        public Usuario GetUsuario(string nick, string pass)
        {
            Usuario encontrado = null;
            nick = convertirAMayuscula(nick);
            foreach (Usuario us in Usuarios)
            {
                if (us.Nick.Equals(nick) && us.Password.Equals(pass))
                {
                    encontrado = us;
                }
            }
            return encontrado;
        }

        public Usuario AltaUsuarioCliente(string nombre, string apellido, string email, DateTime fechaNacimiento, string password, string nick)
        {
            Usuario nuevo = null;

            if (validarNombreApellido(nombre) == true && validarNombreApellido(apellido) == true && ExisteEmail(email) == false && ValidarFechaNacimiento(fechaNacimiento) == true && validarPass(password) == true && ExisteNick(nick) == false)
            {
                nick = convertirAMayuscula(nick);
                nuevo = new UsuarioCliente(nombre, apellido, email, fechaNacimiento, password, nick);
                Usuarios.Add(nuevo);
            }
            return nuevo;
        }



        // obtener usuario mediante un ID
        public Usuario GetUsuarioId(int? id)
        {
            Usuario encontrado = null;
            foreach (Usuario usu in Usuarios)
            {
                if (usu.idUsuario.Equals(id))
                {
                    encontrado = usu;
                }
            }
            return encontrado;
        }

        //------------------------
        //VALIDACIONES DE REGISTRO
        //------------------------
        private bool validarNombreApellido(string texto)
        {
            bool valido = false;
            bool largo = false;
            if (texto != null)
            {
                if (texto.Count() >= 2)
                {

                    largo = true;
                }
            }
            if (largo == true)
            {
                valido = true;
            }
            return valido;
        }
        private bool validarPass(string pass)
        {
            bool valido = false;
            bool mayuscula = false, numero = false, minuscula = false, largo = false;
            if (pass != null)
            {
                for (int i = 0; i < pass.Count(); i++)
                {
                    if (char.IsNumber(pass, i))
                    {
                        numero = true;
                    }
                    if (Encoding.ASCII.GetBytes(pass.ToString())[i] >= 65 & Encoding.ASCII.GetBytes(pass.ToString())[i] <= 90)
                    {
                        mayuscula = true;
                    }
                    if (Encoding.ASCII.GetBytes(pass.ToString())[i] >= 97 & Encoding.ASCII.GetBytes(pass.ToString())[i] <= 122)
                    {
                        minuscula = true;
                    }
                    if (pass.Count() >= 6)
                    {
                        largo = true;
                    }
                }
                if (mayuscula && numero && minuscula && largo)
                {
                    valido = true;
                }

            }
            return valido;

        }

        private bool ExisteNick(string nick)
        {
            bool valido = false;
            nick = convertirAMayuscula(nick);
            foreach (Usuario us in Usuarios)
            {
                if (us.Nick.Equals(nick))
                {
                    valido = true;
                }
            }
            return valido;
        }
        private bool ExisteEmail(string email)
        {
            bool valido = false;
            foreach (Usuario us in Usuarios)
            {
                if (us.Email.Equals(email))
                {
                    valido = true;
                }
            }
            return valido;
        }
        private bool ValidarFechaNacimiento(DateTime fecha)
        {
            bool valido = false;
            if (fecha < DateTime.Now)
            {
                valido = true;
            }
            return valido;
        }

        //Convierte un txt a mayuscula
        private string convertirAMayuscula(string txt)
        {
            return txt.ToUpper();
        }
        //listar actividades con el mismo nombre sirve para las estadisticas de  operador 10 11 2021
        public List<Actividad> GetNombreActividadesLugar(string Nombre)
        {
            List<Actividad> ActividadesA = new List<Actividad>();
            foreach (Actividad a in Actividades)
            {
                if (a.Lugar.Nombre.Equals(Nombre))
                {
                    ActividadesA.Add(a);
                }
            }
            return ActividadesA;
        }

        // lista actividades con un limite de fechas y un nombre de categoria sirve para estadisticas de operador 11 11 2021
        public List<Actividad> GetActividadesEntreFechasYCategoria(DateTime f1, DateTime f2, string NombreCategoria)
        {
            List<Actividad> ActividadesA = new List<Actividad>();
            if (f1 != null && f2 != null && f1 != f2)
            {
                if (f1 > f2)
                {
                    DateTime aux = f1;
                    f1 = f2;
                    f2 = aux;
                }
                foreach (Actividad a in Actividades)
                {
                    if (a.FechaYHora > f1 && a.FechaYHora < f2 && a.Categoria.Nombre.Equals(NombreCategoria))
                    {
                        ActividadesA.Add(a);
                    }
                }
            }
            return ActividadesA;
        }


        //------------------------------------------------------------
        //--------------------------COMPRAS---------------------------
        //------------------------------------------------------------


        //retorna las compras con mayor valor sirve para estadisticas de operador 11 11 2021
        public List<Compra> GetComprasDeMayorValor()
        {
            List<Compra> Comprasdemayorvalor = new List<Compra>();
            double Mayorvalor = 0;
            foreach (Compra C in Compras)
            {
                if (C.PrecioTotal() > Mayorvalor)
                {
                    Comprasdemayorvalor.Add(C);
                    Mayorvalor = C.PrecioTotal();
                    Comprasdemayorvalor.Clear();
                }

                if (C.PrecioTotal().Equals(Mayorvalor))
                {
                    Comprasdemayorvalor.Add(C);
                }
            }
            return Comprasdemayorvalor;
        }


        // ALTA DE COMPRA
        public void AltaCompra(Actividad actividadComprada, int cantEntradas, Usuario usuario, DateTime fechaCompra)
        {
            Compra nueva = null;
            double precioFinal = actividadComprada.PrecioActividad() * cantEntradas;
            if (cantEntradas > 5)
            {
                precioFinal -= precioFinal * 0.05;
            }
            nueva = new Compra(actividadComprada, cantEntradas, usuario, fechaCompra, precioFinal);
            Compras.Add(nueva);
        }

        //intento de dar like
        public void darLike(int idActi)
        {
            Actividad activi = GetActividad(idActi);
            activi.CantidadMG++;
        }



        //Devuelve una compra
        public Compra  GetCompra(int idCompra)
        {
            Compra buscada = null;
            foreach (Compra item in Compras)
            {
                if (item.Id.Equals(idCompra))
                {
                    buscada = item;

                }

            }
            return buscada;
        }




        // Cambiar estado a cancelado de una compra
        public void CambiarEstadoDeCompra(Compra comp)
        {
            Actividad activComp = comp.ActividadComprada;
            TimeSpan dato =  activComp.FechaYHora- DateTime.Now;
            if (dato.TotalHours > 24)
            {

            comp.Estado = Compra.Estados.cancelada;
            }
            
        }


        //retorna clientes ordenados alfabeticamente 
        public List<Usuario> GetClientes()
        {
            List<Usuario> Clientes = new List<Usuario>();
            foreach(Usuario u in Usuarios)
            {
                if (u.TipoUsuario == "cliente")
                {
                    Clientes.Add(u);
                }
            }
            Clientes.Sort();
            return Clientes;

        }

















        public void Precarga()
        {
            Categoria cat1 = AltaCategoria("Cine", "Noche de cine");
            Categoria cat2 = AltaCategoria("Teatro", "Stand up");
            Categoria cat3 = AltaCategoria("Concierto", "The police");
            Categoria cat4 = AltaCategoria("Feria gastronomica", "Varios food trucks");
            Abierto a1 = AltaLugarAbierto("Estadio Centenario", 35000);
            Abierto a2 = AltaLugarAbierto("Teatro de Verano", 2500);
            Abierto a3 = AltaLugarAbierto("Rural del Prado", 2000);
            Abierto a4 = AltaLugarAbierto("Plaza de Mayo", 300);
            Abierto a5 = AltaLugarAbierto("Faro Punta Carretas", 500);
            Cerrado c1 = AltaLugarCerrado("Antel Arena", 800, true, 20000);
            Cerrado c2 = AltaLugarCerrado("Teatro Metro", 200, false, 2);
            Cerrado c3 = AltaLugarCerrado("Teatro Solis", 700, true, 2);
            Cerrado c4 = AltaLugarCerrado("Movie Center", 150, true, 2);
            Cerrado c5 = AltaLugarCerrado("Montevideo shopping", 650, true, 2);
            Actividad act1 = AltaActividad(cat3, DateTime.Parse("2024-09-21 16:00"), a2, EdadMinima.c16, 10000, "Espectaculo musical");
            Actividad act2 = AltaActividad(cat2, DateTime.Parse("2023-08-21 20:00"), c1, EdadMinima.c18, 5800, "Espectaculo de stand up");
            Actividad act3 = AltaActividad(cat4, DateTime.Parse("2022-07-16 12:00"), c3, EdadMinima.p, 50, "Evento de gastronomia y animales");
            Actividad act4 = AltaActividad(cat4, DateTime.Parse("2022-07-10 10:00"), c5, EdadMinima.p, 150, "Evento de gastronomia");
            Actividad act5 = AltaActividad(cat1, DateTime.Parse("2023-09-21 16:20"), c4, EdadMinima.c13, 503, "Rapido y furioso 32");
            Actividad act6 = AltaActividad(cat1, DateTime.Parse("2022-10-20 17:00"), a5, EdadMinima.p, 1450, "Cine al aire libre");
            Actividad act7 = AltaActividad(cat3, DateTime.Parse("2022-01-11 22:00"), a1, EdadMinima.c18, 324, "Espectaculo musical nro 23");
            Actividad act8 = AltaActividad(cat3, DateTime.Parse("2021-12-05 17:00"), a4, EdadMinima.p, 1, "The police en vivo");
            Actividad act9 = AltaActividad(cat2, DateTime.Parse("2024-09-21 16:00"), c2, EdadMinima.c16, 1, "Espectaculo de stand up");
            Actividad act10 = AltaActividad(cat1, DateTime.Parse("2022-09-21 20:00"), c3, EdadMinima.p, 1, "Cine antiguo");




            //Precarga usuarios
            UsuarioOperador op1 = new UsuarioOperador("Andres", "Fernandez", "AFernaandez@gmail.com", DateTime.Parse("1994-09-21"), "Abcd1234", "OPERADOR1");
            Usuarios.Add(op1);
            UsuarioOperador op2 = new UsuarioOperador("Martina", "Acevedo", "MartinaAC@gmail.com", DateTime.Parse("1990-05-11"), "Abcd1234", "OPERADOR2");
            Usuarios.Add(op2);
            Usuario u1 = AltaUsuarioCliente("Federico", "Perez", "FP@gmail.com", DateTime.Parse("2000-08-29"), "Abcd1234", "USUARIO1");
            Usuario u2 = AltaUsuarioCliente("Ana", "Rapal", "rapalA@gmail.com", DateTime.Parse("2005-03-01"), "Abcd1234", "USUARIO2");



            //COMPRAS
            DateTime ahora = DateTime.Now;
            AltaCompra(act10, 3, u1, ahora);
            AltaCompra(act6, 2, u1, ahora);
            AltaCompra(act8, 5, u1, ahora);
            AltaCompra(act3, 1, u2, ahora);
            AltaCompra(act5, 4, u2, ahora);
            AltaCompra(act1, 4, u2, ahora);
            AltaCompra(act2, 3, u1, ahora);
            AltaCompra(act3, 2, u1, ahora);


        }


    }
}
