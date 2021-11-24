using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Obli_2_p2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obli_2_p2.Controllers
{
    public class ActividadesController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NombreActividades()
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                var lugares = s.GetLugares();
                ViewBag.lugares = lugares;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult NombreActividades(string nombre)
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                var lugares = s.GetLugares();
                ViewBag.lugares = lugares;
                if (nombre != null)
                {
                    var actividades = s.GetNombreActividadesLugar(nombre);

                    ViewBag.actividades = actividades;
                    return View();
                }else
                {
                    ViewBag.mensaje = "Verifique los datos ingresados";
                    return View();
                }


            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        public IActionResult FechaCategoria()
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                List<Categoria> ListaCategorias = s.GetCategorias();
                ViewBag.ListaCat = ListaCategorias;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult FechaCategoria(DateTime f1, DateTime f2, string categoria)
        {
            if (HttpContext.Session.GetString("UsuarioId") != null && HttpContext.Session.GetString("UsuarioRol").Equals("operador"))
            {
                if (f1 != null && f2 != null & categoria != null)
                {
                    var actividades = s.GetActividadesEntreFechasYCategoria(f1, f2, categoria);

                    ViewBag.actividades = actividades;
                    return View();
                }
                else
                {
                    ViewBag.resultado = "Verifique los datos ingresados";
                    return View();
                }


            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
