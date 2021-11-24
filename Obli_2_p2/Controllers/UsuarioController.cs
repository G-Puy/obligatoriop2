using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Obli_2_p2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obli_2_p2.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            var lista = s.GetActividades();
            ViewBag.ListaActividades = lista;
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string nick, string pass)
        {


            Usuario exitoso = null;
            exitoso = s.GetUsuario(nick, pass);
            if (HttpContext.Session.GetString("UsuarioNick") == null)
            {
                if (exitoso != null)
                {

                    // almacena usuario en session
                    HttpContext.Session.SetString("UsuarioNick", exitoso.Nick);
                    HttpContext.Session.SetString("UsuarioRol", exitoso.TipoUsuario);
                    HttpContext.Session.SetInt32("UsuarioId", exitoso.idUsuario);

                    if (exitoso.TipoUsuario == "cliente")
                    {
                        return RedirectToAction("UsuarioRegistrado", "Usuario");
                    }
                    else
                    {
                        return RedirectToAction("UsuarioOperador", "Usuario");
                    }


                }
                else
                {
                    ViewBag.Msj = "Usuario o Contraseña incorrecto";
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }






        public IActionResult RegistrarCliente()
        {
            if (HttpContext.Session.GetString("UsuarioNick") == null)
            {
                var listaUsuarios = s.GetClientes();
                ViewBag.usuarios = listaUsuarios;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }



        }
        [HttpPost]
        public IActionResult RegistrarCliente(string nombre, string apellido, string email, DateTime fechaNacimiento, string password, string nick)
        {

            if (HttpContext.Session.GetString("UsuarioNick") == null)
            {
                Usuario exitoso = null;
                exitoso = s.AltaUsuarioCliente(nombre, apellido, email, fechaNacimiento, password, nick);
                if (exitoso != null)
                {
                    ViewBag.Msj = "Registro exitoso";
                }
                else
                {
                    ViewBag.Msj = "Error al registrar, verifique los datos";
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }







        }
        public IActionResult UsuarioRegistrado()
        {
            int? idUsuario = HttpContext.Session.GetInt32("UsuarioId");
            if (idUsuario != null)
            {
                var usuarioActual = s.GetUsuarioId(idUsuario);
                ViewBag.UsuAct = usuarioActual;
                var lista = s.GetActividades();
                ViewBag.ListaActividades = lista;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult UsuarioRegistrado(int idActividadActual)
        {
            s.darLike(idActividadActual);

            int? idUsuario = HttpContext.Session.GetInt32("UsuarioId");

            if (idUsuario != null && HttpContext.Session.GetString("UsuarioRol").Equals("cliente"))
            {
                var lista = s.GetActividades();
                ViewBag.ListaActividades = lista;
                var usuarioActual = s.GetUsuarioId(idUsuario);
                ViewBag.UsuAct = usuarioActual;

                return View();


            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }





        public IActionResult UsuarioOperador()
        {
            int? idUsuario = HttpContext.Session.GetInt32("UsuarioId");
            if (idUsuario != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                Usuario logeado = s.GetUsuarioId(idUsuario);
                ViewBag.nombre = logeado.Nombre;
                ViewBag.apellido = logeado.Apellido;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UsuarioRol") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [HttpPost]
        public IActionResult Logout(string n)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Lista()
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                var lista = s.GetClientes();
                ViewBag.listaClientes = lista;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
