
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using salaEscape.Models;

namespace salaEscape.Controllers
{

    public class EscapeController : Controller
    {
        private readonly ILogger<EscapeController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Respuesta(int sala, string ans)
        {


            string salaString = sala.ToString();
            string numHabitacion = "habitacion" + salaString;

            if (ans == null)
            {
                if (sala == 1)
                {
                    string[] pistas = { "La persona más nefasta de todo el periodismo argentino", "Su madre es Victoria Millán Blanco.", "Trabajó en Intrusos" };
                    ViewBag.Pistas = pistas;
                }
                else if (sala == 2)
                {
                    string[] pistas = { "Su nombre original es Rosa María Juana Martínez Suárez", "Tenía una hermana melliza (QEPD)", "Hace el mismo programa desde 1968 y la siguen viendo." };
                    ViewBag.Pistas = pistas;
                }
                else if (sala == 3)
                {
                    string[] pistas = { "Nació en Santa Fe el 16 de mayo de 1978", "Debutó como jugador ante el Real Sporting de Gijón", "Salió campeón del mundial Sub-20 2007, en Malasia" };
                    ViewBag.Pistas = pistas;
                }
                else if (sala == 4)
                {
                    string[] pistas = { "El mejor jugador de la historia", "Lo llamaban pelusa, o cebollita", "El día que supo cuánto pesaba la del mundo (RGB = D/M/Y)" };
                    ViewBag.Pistas = pistas;
                }
                return View(numHabitacion);
            }
            string input = ans.ToLower();

            if ((input == "jorge rial" || input == "jorge" || input == "rial") && sala == 1)
            {
                Thread.Sleep(3000);
                string[] pistas = { "Su nombre original es Rosa María Juana Martínez Suárez", "Tenía una hermana melliza (QEPD)", "Hace el mismo programa desde 1968 y la siguen viendo." };
                ViewBag.Pistas = pistas;
                return View("habitacion2");
            }
            if (sala == 1)
            {
                Thread.Sleep(1500);
                string[] pistas = { "La persona más nefasta de todo el periodismo argentino", "Su madre es Victoria Millán Blanco.", "Trabajó en Intrusos" };
                ViewBag.Pistas = pistas;
                return View("habitacion1");
            }

            if ((input == "1927-02-23") && sala == 2)
            {
                Thread.Sleep(3000);
                string[] pistas = { "Nació en Santa Fe el 16 de mayo de 1978", "Debutó como jugador ante el Real Sporting de Gijón", "Salió campeón del mundial Sub-20 2007, en Malasia" };
                ViewBag.Pistas = pistas;
                return View("habitacion3");
            }
            if (sala == 2)
            {
                Thread.Sleep(1500);
                string[] pistas = { "Su nombre original es Rosa María Juana Martínez Suárez", "Tenía una hermana melliza (QEPD)", "Hace el mismo programa desde 1968 y la siguen viendo." };
                ViewBag.Pistas = pistas;
                return View("habitacion2");
            }


            if ((input == "scaloni" || input == "lionel scaloni" || input == "lionel" || input == "scaloneta" || input == "la scaloneta" || input == "fulbo shampan") && sala == 3)
            {
                Thread.Sleep(3000);
                string[] pistas = { "El mejor jugador de la historia", "Lo llamaban pelusa, o cebollita", "El día que supo cuánto pesaba la del mundo (RGB = D/M/Y)" };
                ViewBag.Pistas = pistas;
                return View("habitacion4");
            }
            if (sala == 3)
            {
                Thread.Sleep(1500);
                string[] pistas = { "Nació en Santa Fe el 16 de mayo de 1978", "Debutó como jugador ante el Real Sporting de Gijón", "Salió campeón del mundial Sub-20 2007, en Malasia" };
                ViewBag.Pistas = pistas;
                return View("habitacion3");
            }

            if ((input == "#1d0656") && sala == 4)
            {
                Thread.Sleep(3000);
                return View("inputfinal");
            }
            if (sala == 4)
            {
                Thread.Sleep(1500);
                string[] pistas = { "El mejor jugador de la historia", "Lo llamaban pelusa, o cebollita", "El día que supo cuánto pesaba la del mundo (RGB = D/M/Y)" };
                ViewBag.Pistas = pistas;
                return View("habitacion4");
            }
            return View(numHabitacion);
        }


        public IActionResult inputFinalRespuesta(int input1name, int input2name, int input3name, int input4name)
        {
            int[] respuestaCorrecta = { 3, 0, 7, 5 };
            int[] input = { input1name, input2name, input3name, input4name };

            if (input.SequenceEqual(respuestaCorrecta))
            {
                Thread.Sleep(3000);
                return View("victoria");
            }
            else
            {
                Thread.Sleep(1500);
                return View("inputfinal");
            }
        }

        public IActionResult habitacion1()
        {
            string[] pistas = { "La persona más nefasta de todo el periodismo argentino", "Su madre es Victoria Millán Blanco.", "Trabajó en Intrusos" };
            ViewBag.Pistas = pistas;
            return View();
        }
        public IActionResult habitacion2()
        {
            string[] pistas = { "Su nombre original es Rosa María Juana Martínez Suárez", "Tenía una hermana melliza (QEPD)", "Hace el mismo programa desde 1968 y la siguen viendo." };
            ViewBag.Pistas = pistas;
            return View();
        }
        public IActionResult habitacion3()
        {
            string[] pistas = { "Nació en Santa Fe el 16 de mayo de 1978", "Debutó como jugador ante el Real Sporting de Gijón", "Salió campeón del mundial Sub-20 2007, en Malasia" };
            ViewBag.Pistas = pistas;
            return View();
        }
        public IActionResult habitacion4()
        {
            string[] pistas = { "El mejor jugador de la historia", "Lo llamaban pelusa, o cebollita", "El día que supo cuánto pesaba la del mundo (RGB = D/M/Y)" };
            ViewBag.Pistas = pistas;
            return View();
        }

        public IActionResult victoria()
        {
            return View();
        }

        public IActionResult inputfinal()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
