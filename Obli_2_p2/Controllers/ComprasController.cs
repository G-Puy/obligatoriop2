using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Obli_2_p2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obli_2_p2.Controllers
{
    public class ComprasController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DetallesCompra(int idActividad)
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("cliente"))
            {
                Actividad seleccionada = s.GetActividad(idActividad);
                ViewBag.Actividad = seleccionada;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult DetallesCompra(int idActividad, int cantEnt)
        {
            Actividad actividad = s.GetActividad(idActividad);
            int? idUsuario = HttpContext.Session.GetInt32("UsuarioId");
            if (idUsuario != null && HttpContext.Session.GetString("UsuarioRol").Equals("cliente"))
            {
                if (cantEnt > 0 && actividad != null)
                {
                    Usuario usu = s.GetUsuarioId(idUsuario);
                    s.AltaCompra(actividad, cantEnt, usu, DateTime.Now);
                }
                return RedirectToAction("ComprasRealizadas", "Compras");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }


        public IActionResult ComprasRealizadas()
        {
            // retorna una lista de compras realizadas por el usuario logueado
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("cliente"))
            {
                List<Compra> ComprasPorUsuario = s.GetComprasUsuario(HttpContext.Session.GetInt32("UsuarioId"));
                var resultado = ComprasPorUsuario;
                ViewBag.ListaComprasHechas = resultado;
                return View();
                // que retorne la vista si tiene al menos una compra realizada y sino que retorne la vista de compra
                //if (s.GetComprasUsuario(HttpContext.Session.GetInt32("UsuarioId")).Count > 0)
                //{
                // }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost]
        public IActionResult ComprasRealizadas(int idCompra)
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("cliente"))
            {
                Compra comp = s.GetCompra(idCompra);
                s.CambiarEstadoDeCompra(comp);
                List<Compra> ComprasPorUsuario = s.GetComprasUsuario(HttpContext.Session.GetInt32("UsuarioId"));
                var resultado = ComprasPorUsuario;
                ViewBag.ListaComprasHechas = resultado;
                return View();
                // que retorne la vista si tiene al menos una compra realizada y sino que retorne la vista de compra
                //if (s.GetComprasUsuario(HttpContext.Session.GetInt32("UsuarioId")).Count > 0)
                //{
                // }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        public IActionResult ComprasFechas()
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult ComprasFechas(DateTime f1, DateTime f2)
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                if (f1 != f2)
                {
                    var Compras = s.GetComprasFechas(f1, f2);
                    var Precio = s.PrecioTotal(Compras);
                    ViewBag.compras = Compras;
                    ViewBag.precio = Precio;
                    return View();
                }
                else
                {
                    ViewBag.errorFechas = "Verifique las fechas";
                    return View();
                }


            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        public IActionResult Estadisticas()
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {

                return View();

            }
            else
            {
                return RedirectToAction("UsuarioRegistrado", "Usuario");
            }

        }
        public IActionResult MayorValor()
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                var Compras = s.GetComprasDeMayorValor();
                ViewBag.compras = Compras;
                return View();

            }
            else
            {
                return RedirectToAction("UsuarioRegistrado", "Usuario");
            }

        }


    }
}
