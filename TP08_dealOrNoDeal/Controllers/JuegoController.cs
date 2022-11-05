using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dealOrNoDeal.Models;

namespace dealOrNoDeal.Controllers
{
    public class JuegoController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static int cantMaletines = 26;
        private static DealOrNo juego;
        public static Dictionary<int, string> IndexYCripto = new Dictionary<int, string> { };
        private static string[] nombreCripto = new string[] { "Shiba", "Tron", "Dogecoin", "Stellar", "USDT", "IOTA", "Matic", "Ada", "XTZ", "PVU", "Pancake", "UNI", "Link", "Terra", "Ethereum Classic", "Polkadot", "Filecoin", "Litecoin", "Solana", "Monero", "BNB", "AAVE", "BCH", "Maker", "ETH", "Bitcoin" };

        public JuegoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.cantMaletines = cantMaletines;
            ViewBag.nombreCriptos = nombreCripto;
            return View();
        }

        public IActionResult IniciarJuego(int elegido)
        {
            Console.WriteLine("Iniciando...");
            ViewBag.nashe = "nashe";
            juego = new DealOrNo(elegido);
            juego.IniciarJuego(elegido);
            
            ViewBag.IndexYCripto = IndexYCripto;
            ViewBag.JugadasRestantes = juego.JugadasRestantes;
            ViewBag.Maletines = juego.Maletines;
            ViewBag.nombreCriptos = nombreCripto;
            return View("Juego");
        }

        public IActionResult AbrirMaletin(int abierto)
        {
            string criptoMaletin = juego.AbrirMaletin(abierto);
            IndexYCripto.Add(juego.Maletines[abierto - 1].Numero, juego.Maletines[abierto - 1].NombreCripto);

            foreach(var item in IndexYCripto){
                Console.WriteLine("INDEX - " + item.Key.ToString() + ": " + item.Value.ToString());
            }
            ViewBag.IndexYCripto = IndexYCripto;
            ViewBag.Maletines = juego.Maletines;
            Console.WriteLine("JUGADAS RESTANTES CONTrOLLER: " + juego.JugadasRestantes.ToString());
            ViewBag.JugadasRestantes = juego.JugadasRestantes;
            ViewBag.nombreCriptos = nombreCripto;
            if (IndexYCripto.Count == cantMaletines- 2){
                for(int i=0; i< cantMaletines; i++){
                    if(juego.Maletines[i].Abierto || juego.Maletines[i].Elegido){
                        continue;
                    }
                    ViewBag.maletinExtra = i+1;
                }
                int elegido = 0;
                for(int i = 0; i < juego.Maletines.Length; i++){
                    if(juego.Maletines[i].Elegido){
                        elegido = i+1;
                        break;
                    }
                }
                ViewBag.maletinElegido = elegido;
                return View("QuedanDos");
            }
            else if (juego.JugadasRestantes == 0){
                ViewBag.oferta = juego.OfertaBanca();
                return View("Decision");
            }
            return View("Juego");
        }

        public IActionResult DecisionOferta(bool aceptar){
            if(aceptar){
                ViewBag.PrecioFinal = juego.OfertaBanca();
                juego.JugadasRestantes = juego.CantJugadas;
                return View("Final");
            }
            else{
                juego.JugadasRestantes = juego.CantJugadas;
                ViewBag.IndexYCripto = IndexYCripto;
                ViewBag.Maletines = juego.Maletines;
                ViewBag.JugadasRestantes = juego.JugadasRestantes;
                ViewBag.nombreCriptos = nombreCripto;
                return View("Juego");
            }
            
        }

        public IActionResult UltimoMaletin(int elegido){
            int precioFinal = juego.DecisionDosMaletines(elegido);
            
            ViewBag.PrecioFinal = precioFinal;
            return View("Final");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult test(){
            return View();
        }

        public IActionResult ResetGame()
        {
            IndexYCripto.Clear();
            juego = new DealOrNo(0);
            juego.JugadasRestantes = juego.CantJugadas;
            return View("../home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
