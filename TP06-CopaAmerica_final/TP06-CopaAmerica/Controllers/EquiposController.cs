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
    public class EquiposController : Controller
    {
        public IActionResult VerEquipos()
        {
            string[] Equipos = { "Argentina", "Bolivia", "Brasil", "Chile", "Colombia", "Ecuador", "Paraguay", "Peru", "Uruguay", "Venezuela" };
            string[] Frases = {
            "Alfredo Di Stéfano",
            "Marco Etcheverry",
            "Pelé",
            "Arturo Vidal",
            "Carlos Valderrama",
            "Álex Aguinaga",
            "José Luis Chilavert",
            "Teófilo Cubillas",
            "Enzo Francescoli",
            "Salomón Rondón"
            };


            ViewBag.Frases = Frases;
            ViewBag.Equipos = Equipos;
            return View();
        }

        public IActionResult VerJugadoresEquipo(string Equipo)
        {

            Dictionary<string, string> Campeones = new Dictionary<string, string>{
                {"1916","Uruguay"},
                {"1917","Uruguay"},
                {"1919","Brasil"},
                {"1920","Uruguay"},
                {"1921","Argentina"},
                {"1922","Brasil"},
                {"1923","Uruguay"},
                {"1924","Uruguay"},
                {"1925","Argentina"},
                {"1926","Uruguay"},
                {"1927","Argentina"},
                {"1929","Argentina"},
                {"1935","Uruguay"},
                {"1937","Argentina"},
                {"1939","Perú"},
                {"1941","Argentina"},
                {"1942","Uruguay"},
                {"1945","Argentina"},
                {"1946","Argentina"},
                {"1947","Argentina"},
                {"1949","Brasil"},
                {"1953","Paraguay"},
                {"1955","Argentina"},
                {"1956","Uruguay"},
                {"1957","Argentina"},
                {"1959-1","Argentina"},
                {"1959-2","Uruguay"},
                {"1963","Bolivia"},
                {"1967","Uruguay"},
                {"1975","Peru"},
                {"1979","Paraguay"},
                {"1983","Uruguay"},
                {"1987","Uruguay"},
                {"1989","Brasil"},
                {"1991","Argentina"},
                {"1993","Argentina"},
                {"1995","Uruguay"},
                {"1997","Brasil"},
                {"1999","Brasil"},
                {"2001","Colombia"},
                {"2004","Brasil"},
                {"2007","Brasil"},
                {"2011","Uruguay"},
                {"2015","Chile"},
                {"2016","Chile"},
                {"2019","Brasil"},
                {"2021","Argentina"}
                };

            string[] Jugadores = new string[11] { "", "", "", "", "", "", "", "", "", "", "" };
            string[] EquiposJugadores = new string[11] { "", "", "", "", "", "", "", "", "", "", "" };
            string[] MasDatos = new string[2] { "", "" };
            int[] Formacion = new int[4] { 3, 3, 4, 1 };
            string DT = "";
            string DT_IMG = "";
            switch (Equipo)
            {
                case "Argentina":
                    Jugadores = new string[11] { "Lionel Messirve", "Tagliafico", "Kum Aguero", "Di Jose Maria", "Lautaro Martínez", "Lo Celoso", "Julián Álvarez", "Acuña", "Naruto Gonzalez", "Lucas Martinez II", "Franco Armani" };
                    EquiposJugadores = new string[11] { "Barca", "Ajax", "Barca", "PSG", "Inter", "Tutson F.C.", "Bover Plate", "SeVILLA", "Full-Otaku F.C.", "CoscuArmy E-Sports", "Tutson F.C." };
                    MasDatos = new string[2] { "", "" };
                    Formacion = new int[4] { 2, 4, 4, 1 };
                    DT = "Lionel Scaloni";
                    DT_IMG = "Scaloni";
                    break;

                case "Bolivia":
                    Jugadores = new string[11] { "Daniel Anejnereb", "Maxi Anaznam", "Javier Calamrdo", "Carlos Lampone", "Hector Tilla", "Ezequiel Binker", "Julio Rojas", "Julio Achura", "Rodrigo Ramallo", "Uriel Canosa", "Julio Sagrado" };
                    EquiposJugadores = new string[11] { "Bolivia Unida FC", "Real Potosí", "Medialunas FC", "Cinta Roja Unida", "Staying Alive F.C.", "Rapsodia Bohemia", "Vela Puerca C.F.", "Atlético Palmaflor", "Oriente Petrolero", "Royal Pari", "Manchester Campo" };
                    Formacion = new int[4] { 4, 3, 3, 1 };
                    DT = "César Farías";
                    DT_IMG = "Farias";
                    break;

                case "Brasil":
                    Jugadores = new string[11] { "Neymar", "Allison Son", "Roberto Firmino", "Gabriel Barbosa", "DOUglas Luiz", "Casimiro", "Fabinho", "Emerson", "Juanceto01", "Fred", "Gabriel Jesu" };
                    EquiposJugadores = new string[11] { "Racing", "Huachipato", "Flamengo", "River", "Inter Miami", "U. Católica", "Tato FC", "Florianópolis CF", "Botafogo", "Vasco da Gama", "Club Hípico" };
                    Formacion = new int[4] { 2, 3, 5, 1 };
                    DT = "Tite";
                    DT_IMG = "Tite";
                    break;

                case "Chile":
                    Jugadores = new string[11] { "Gabriel Arias", "Kiko Mendel", "Omar Palacios", "Lucas Maxipan", "Arturo Vidal", "Erick Pulgar", "Tito Brereton", "Nico Castellon", "Francisco Sierrabaja", "Porte Galdames", "El Vargas" };
                    EquiposJugadores = new string[11] { "Universidad De Chile", "Alianza Lima", "River, el mas grande", "Termidor F.C.", "Mate Dulche", "Cobresal", "O'Higgins", "Unión La Calera", "Montealto", "Gargamel Club", "Colo-Colo" };
                    Formacion = new int[4] { 4, 2, 4, 1 };
                    DT = "Martín Lasarte";
                    DT_IMG = "Lasarte";
                    break;

                case "Colombia":
                    Jugadores = new string[11] { "Robe Borré", "Douglas Orilla", "Sebastian Pere", "Diushtacs Sanchez", "Agustin Morelos", "Width Barrios", "Yorri Mina", "Salvio Medina", "Roberto Chará", "Height Tesillo", "Doctor Opina" };
                    EquiposJugadores = new string[11] { "América de Cali", "Envigado Fútbol Club", "Club Ethereum", "Club Atlético Bucaramanga", "Millonarios Fútbol Club", "Deportivo Independiente Medellín", "Tezos F.C", "Patriotas Boyacá Fútbol Club", "Club Independiente Santa Fe", "Deportivo Pereira", "Polkadot C.F." };
                    Formacion = new int[4] { 1, 4, 5, 1 };
                    DT = "Reinaldo Rueda";
                    DT_IMG = "Rueda";
                    break;

                case "Ecuador":
                    Jugadores = new string[11] { "Munch Entrada", "Jeferson Palacios", "Xuy Arreaga", "Palacio Ortiz", "Javi Carabali", "Pedro Hincapie", "Jorge Mena", "Domingo Diaz", "A. Preciado", "Mayo Nesa", "Franco Alto" };
                    EquiposJugadores = new string[11] { "9 de Octubre", "Liga de Quito", "Universidad Católica", "Guayaquil City", "Emelec", "Barcelona", "Orense", "Manta", "Mushuc Runa", "Delfín", "Emelec" };
                    Formacion = new int[4] { 4, 4, 2, 1 };
                    DT = "Gustavo Alfaro";
                    DT_IMG = "Alfaro";
                    break;

                case "Paraguay":
                    Jugadores = new string[11] { "Gastón Oreja", "Matías Rojas", "Hector Martinez II", "Hernesto Espinola", "Rodrigo Sanchez de Tomson", "Lucas Almidon", "Rwison Piris Da Motta", "Brian Silva IV", "Dante 'Gordo' Avalos", "Ariel Cuba", "Carlos Gonzalez" };
                    EquiposJugadores = new string[11] { "Atlético Tembetary", "Resistencia", "Sportivo Trinidense", "Deportivo Santaní", "Sport Colombia", "General Caballero ZC", "San Lorenzo", "Atlántida", "River Plate", "Resistencia", "Tacuary" };
                    Formacion = new int[4] { 1, 4, 5, 1 };
                    DT = "Eduardo Berizzo";
                    DT_IMG = "Berizzo";
                    break;

                case "Peru":
                    Jugadores = new string[11] { "Sanson Peña", "Alberto Carrilo", "Piter Gallese", "Carlitos Cuevas", "Gaudio Montaña", "Pepito Rio", "Mario Santos", "Claudio Miller", "Carlitos Carlos", "Juan Sabado Feron", "Gregorio Simson" };
                    EquiposJugadores = new string[11] { "Sporting Cristal", "Universitario", "Binacional", "Universidad César Vallejo", "Ayacucho", "Alianza Lima", "Sport Huancayo", "Carlos A. Mannucci", "Melgar", "Cusco FC", "Pirata FC" };
                    Formacion = new int[4] { 3, 4, 3, 1 };
                    DT = "Ricardo Gareca";
                    DT_IMG = "Gareca";
                    break;

                case "Uruguay":
                    Jugadores = new string[11] { "Luis Suarez", "Diego Lugano", "Álvaro Recoba", "Alcides Ghiggia", "José Leandro Andrade", "Héctor Scarone", "Obdulio Varela", "Edison Cavanni", "Diego Forlán", "Enzo Francescoli", "Juan Alberto Schiaffino" };
                    EquiposJugadores = new string[11] { "Nacional", "Rentistas", "Liverpool", "Peñarol", "Montevideo City Torque", "Montevideo Wanderers", "Cerro Largo", "River Plate", "Plaza Colonia", "Deportivo Maldonado", "Boston River" };
                    Formacion = new int[4] { 2, 3, 5, 1 };
                    DT = "Óscar Washington Tabárez";
                    DT_IMG = "Tabarez";
                    break;

                case "Venezuela":
                    Jugadores = new string[11] { "Agustin González", "Jose Martinez", "Bruno Gonzales", "Rocco Celis", "Martin Villavieja", "Román Riquelme II", "Domingo Caballo", "Loco Abreu", "Luis Pereyra", "Lucho Sandobal", "Mango Calpico" };
                    EquiposJugadores = new string[11] { "Academia Puerto Cabello", "Aragua F. C.", "Atlético Venezuela", "LALA FC", "Carabobo F. C.", "Caracas F. C.", "Deportivo La Guaira", "Deportivo Lara", "Deportivo Táchira", "Estudiantes de Mérida", "GV Maracay" };
                    Formacion = new int[4] { 3, 4, 3, 1 };
                    DT = "José Peseiro";
                    DT_IMG = "Peseiro";
                    break;
            }
            ViewBag.Jugadores = Jugadores;
            ViewBag.EquiposJugadores = EquiposJugadores;
            ViewBag.Formacion = Formacion;
            ViewBag.Campeones = Campeones;
            ViewBag.CurrentTeam = Equipo;
            ViewBag.DT = DT;
            ViewBag.DT_IMG = DT_IMG;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}