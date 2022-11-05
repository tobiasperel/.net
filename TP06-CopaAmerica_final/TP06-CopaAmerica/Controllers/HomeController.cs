using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP06_CopaAmericaV2.Models;

namespace TP06_CopaAmericaV2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sedes()
        {
            string[] SedesNombre = new string[5]{
                "Estadio Arena Pantanal de Cuiabá",
                "Estadio Maracaná de Río de Janeiro",
                "Nilton Santos (Engenhão)",
                "Estadio Olímpico de Goiânia",
                "Estadio Mané Garrincha de Brasilia"};

            string[] SedesDesc = new string[5]{
                "Su nombre se debe a la proximidad de la ciudad de Cuiabá al bioma del Pantanal, una llanura aluvial cubierta por una enorme riqueza de fauna y flora que llena gran parte del estado brasileño de Mato Grosso. El diseño del estadio fue pensado priorizando la ventilación de los espacios, debido a las altas temperaturas de Cuiabá. El Arena Pantanal fue construido específicamente para albergar partidos de la Copa del Mundo de 2014 y tiene capacidad para 44.000 personas. En 2021, tendrá un equipo en la Serie A del Campeonato Brasileño: el Cuiabá Esporte Clube.",
                "Uno de los escenarios más famosos del mundo. Sus 78 mil asientos están acostumbrados a los grandes eventos. El campo ha sido testigo de finales de la Copa Libertadores, de los Juegos Olímpicos, de la Copa del Mundo y, en 2021, volverá a acoger la final de la CONMEBOL Copa América. El estadio es famoso, también, por el ‘Maracanazo’. Esta historia comenzó en 1950, con el Mundial de Brasil, en el que Uruguay derrotó a la selección local y se quedó con la Copa Mundo. De ahí el famoso apodo. En 2019, cuando la competición sudamericana se disputó también en Brasil, fue en el Maracaná donde la verdeamarelha se proclamó campeona al vencer a Perú por 3-1.",
                "Casa del Botafogo. Lleva su nombre por el bicampeón mundial Nilton Santos, uno de los mayores ídolos de la historia del club Albinegro. El estadio también es conocido como Engenhão, debido a su ubicación en un barrio de la Zona Norte de Río de Janeiro. Se construyó para albergar las competiciones de los Juegos Panamericanos de Río 2007 y también fue el escenario de varias competiciones de los Juegos Olímpicos de Río 2016. Tiene una capacidad de 45.000 plazas.",
                "Es el estadio más antiguo de Goiânia, capital del estado de Goiás, y alberga clubes de fútbol tradicionales como el Goiás, el Vila Nova, el Goiânia y el Atlético Goianiense. El Olímpico se inauguró oficialmente en 1941 y se modernizó en 2016. Al año siguiente, fue una de las sedes de la Copa Mundial Sub-17. Su capacidad es de 10.000 espectadores. La OMS tanto como la ONU no recomienda emplear esta practica en dicho establecimiento",
                "Ubicado en Brasilia, es el principal estadio de la capital del país. Se construyó en 1974 y se renovó completamente en 2013 para la Copa Confederaciones y el Mundial de 2014. Tiene una capacidad de 72 mil espectadores. La nueva fachada del estadio, que lleva el nombre de uno de los mejores jugadores de la historia del fútbol nacional, el bicampeón mundial Garrincha, se inspira en la arquitectura de Oscar Niemeyer que da cara a toda la ciudad. Aunque Brasilia no tiene hoy ningún equipo en la Serie A del Campeonato Brasileño, el Mané Garrincha acoge con frecuencia partidos de los principales clubes del país. Para la CONMEBOL Copa América 2021, recibirá el partido inaugural entre Brasil y Venezuela, el 13 de junio."
                };
            
            string[] SedesPic = new string[5]{
                "Cuiaba",
                "Rio",
                "Santos",
                "Goiania",
                "Garrincha"
            };
            ViewBag.Nombre = SedesNombre;
            ViewBag.SedesDesc = SedesDesc;
            ViewBag.SedesPic = SedesPic;
            return View();
    }

    public IActionResult UltimosCampeones()
    {
        return View();
    }

    public IActionResult MejoresMomentos()
    {
        return View();
    }

    public IActionResult tabla2()
    {
        return View();
    }
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
