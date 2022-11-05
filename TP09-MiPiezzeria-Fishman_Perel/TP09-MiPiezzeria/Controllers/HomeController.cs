using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Net;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP09_MiPiezzeria.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TP09_MiPiezzeria.Controllers
{
    public class HomeController : Controller
    {

        public void initializePizzas(){
            Pizzeria.ListarIngredientes().Clear();
            Pizzeria.ListarPizzas().Clear();
            Pizzeria.ListarIngredientes().Add(new Ingrediente("Choclo", "https://img1.freepng.es/20181113/kgt/kisspng-corn-on-the-cob-sweet-corn-pastel-de-choclo-grain-cebada-free-here-5beaed9fc44b20.569294711542122911804.jpg"));
            Pizzeria.ListarIngredientes().Add(new Ingrediente("Chocolate", "https://assets.stickpng.com/images/580b57fbd9996e24bc43c0da.png"));
            Pizzeria.ListarIngredientes().Add(new Ingrediente("Tomate", "https://sevilla.abc.es/gurme/wp-content/uploads/sites/24/2016/07/tomate-un-super-alimento-960x540.jpg"));
            
            
            List<Ingrediente> ingredientes = Pizzeria.ListarIngredientes();
            Pizzeria.AgregarPizza(new Pizza("pizza1",60.00,"https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Menem_con_banda_presidencial.jpg/1200px-Menem_con_banda_presidencial.jpg", "Chica", new List<Ingrediente>{ingredientes[0],ingredientes[1]}));
            Pizzeria.AgregarPizza(new Pizza("pizza2",40.00,"https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Menem_con_banda_presidencial.jpg/1200px-Menem_con_banda_presidencial.jpg", "Grande", new List<Ingrediente>{ingredientes[1]}));
            Pizzeria.AgregarPizza(new Pizza("pizza3",80.00,"https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Menem_con_banda_presidencial.jpg/1200px-Menem_con_banda_presidencial.jpg", "Mediana", new List<Ingrediente>{ingredientes[0],ingredientes[1],ingredientes[2]}));
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // initializePizzas();
            ViewBag.Pizzas = Pizzeria.ListarPizzas();
            return View();
        }

        public IActionResult AgregarPizza()
        {
            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            ViewBag.error = false;
            return View("AgregarPizza");
        }

        public IActionResult AgregarIngredientesForm(string nombre, string foto)
        {
            string[] fotoSplit = foto.Split(".");
            string[] fileFormats = {"jpg","png","gif"};
            if(!fileFormats.Contains(fotoSplit[fotoSplit.Length-1])){
                ViewBag.error = true;
                ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
                ViewBag.mensajeError = "¡Me tenes que dar una fotito bb!";
                return View("AgregarIngredientes");
            }
            Pizzeria.ListarIngredientes().Add(new Ingrediente(nombre, foto));
            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            ViewBag.error = false;
            return View("AgregarPizza");
        }

        
        [HttpPost]
        public IActionResult AgregarPizzaForm(string nombre, double precio, string foto, string tamano, List<int> ingrediente)
        {
            Console.WriteLine("TAMAÑO: " + tamano);
            string[] fotoSplit = foto.Split(".");
            string[] fileFormats = {"jpg","png","gif"};
            if (tamano == null && ingrediente.Count != 0)
            {
                ViewBag.error = true;
                ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
                ViewBag.mensajeError = "¡Ponele un tamaño para que tenga algo de sabor!";
                return View("AgregarPizza");
            }
            else if (ingrediente.Count == 0 && tamano != null)
            {
                ViewBag.error = true;
                ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
                ViewBag.mensajeError = "¡Flaco salvo que quieras comer pizzas vacias ponele ingredientes campeon!";
                return View("AgregarPizza");
            }
            else if (ingrediente.Count == 0 && tamano == null)
            {
                ViewBag.error = true;
                ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
                ViewBag.mensajeError = "¡Una pizza no se hace sin tamaño ni ingredientes!";
                return View("AgregarPizza");
            }
            else if (!fileFormats.Contains(fotoSplit[fotoSplit.Length-1])){
                ViewBag.error = true;
                ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
                ViewBag.mensajeError = "¡Me tenes que dar una fotito bb!";
                return View("AgregarPizza");
            }

            List<Ingrediente> IngredientesAgregados = new List<Ingrediente>();
            Console.WriteLine("---INGREDIENTES--- " + ingrediente.Count.ToString());
            foreach (int ingr in ingrediente)
            {
                Ingrediente addedIngrediente = Pizzeria.ListarIngredientes()[ingr];
                IngredientesAgregados.Add(addedIngrediente);
                Console.WriteLine(addedIngrediente.Nombre);
            }
            Console.WriteLine(tamano);
            Pizzeria.AgregarPizza(new Pizza(nombre, precio, foto, tamano, IngredientesAgregados));
            return View("Index");
        }

        private Pizza PizzaFromIdentacion(int identacion){
            List<Pizza> pizzalista = Pizzeria.ListarPizzas();
            foreach (Pizza pizza in pizzalista.ToArray()){
                if(pizza.IdPizza == identacion){
                    return pizza;
                }
            }
            List<Ingrediente> X = new List<Ingrediente>();
            return new Pizza("", 0, "", "", X);
        }

        //Tener en cuenta que cuando borramos una pizza, los indexes van a cambiar
        public IActionResult EliminarPizza(int identacion)
        {
            bool sePudo = Pizzeria.EliminarPizza(PizzaFromIdentacion(identacion));
            
            return View("Index");
        }

        public IActionResult EditarPizza(int identacion){
            ViewBag.Pizza = PizzaFromIdentacion(identacion);
            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            return View("EditarPizza");
        }

        public IActionResult EditarPizzaForm(int pizza, string nombre, double precio, string foto, string tamano, List<int> ingrediente){
            string[] fileFormats = {"jpg","png","gif"};
            Console.WriteLine(tamano);
            if(nombre != null){
                PizzaFromIdentacion(pizza).Nombre = nombre;
            }
            if(precio != 0){
                PizzaFromIdentacion(pizza).Precio = precio;
            }
            if(foto != null){
                if( fileFormats.Contains(foto.Split(".")[foto.Split(".").Length-1])){
                    PizzaFromIdentacion(pizza).Foto = foto;
                }
            }
            if(tamano != null){
                PizzaFromIdentacion(pizza).Tamano = tamano;
            }
            List<Ingrediente> IngredientesAgregados = new List<Ingrediente>();
            Console.WriteLine("---INGREDIENTES--- " + ingrediente.Count.ToString());
            foreach (int ingr in ingrediente)
            {
                Ingrediente addedIngrediente = Pizzeria.ListarIngredientes()[ingr];
                IngredientesAgregados.Add(addedIngrediente);
            }
            PizzaFromIdentacion(pizza).Ingredientes = IngredientesAgregados;
            ViewBag.Pizzas = Pizzeria.ListarPizzas();
            return View("Index");
        }

        public IActionResult AgregarIngredientes()
        {
            ViewBag.error = false;
            return View();
        }




        //Tener en cuenta que cuando borramos una pizza, los indexes van a cambiar
        public IActionResult VerPizza(int identacion)
        {
            List<Ingrediente> X = new List<Ingrediente>();
            Pizza PizzaVerPizza = new Pizza("", 0, "", "", X);
            
            PizzaVerPizza = PizzaFromIdentacion(identacion);
            
            ViewBag.Pizza = PizzaVerPizza;
            ViewBag.Ingredientes = PizzaVerPizza.Ingredientes;
            return View("DetallePizza");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult test()
        {
            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            ViewBag.error = false;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
