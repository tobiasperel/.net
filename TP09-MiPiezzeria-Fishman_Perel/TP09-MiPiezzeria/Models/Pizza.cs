using System;
using System.Collections.Generic;
namespace TP09_MiPiezzeria.Models
{
    public class Pizza
    {
        private static int IdCount = 0;
        private int _IdPizza;
        private string _Nombre;
        private double _Precio;
        private string _UrlFoto;
        private string _Tamano;
        private List<Ingrediente> _ListaIngredientes = new List<Ingrediente>();
        
        public Pizza(string Nombre, double Precio, string UrlFoto, string tamano, List<Ingrediente> listaIngredientes){
            _IdPizza = IdCount;
            _Nombre = Nombre;
            _Precio = Precio;
            _UrlFoto = UrlFoto;
            _Tamano = tamano;
            _ListaIngredientes = listaIngredientes;
            IdCount++;
        }


        public List<Ingrediente> Ingredientes {
            get{ return _ListaIngredientes; }
            set{_ListaIngredientes = value;} 
        }


        //Hay que ver como llegan los ingredientes desde el form 
        //para agregarlos a la pizza como lista de ingredientes
        public void AgregarIngredientes(List<Ingrediente> ingredientes) {
            foreach (Ingrediente ingre in ingredientes)
            {
                _ListaIngredientes.Add(ingre);
            }
        }

        public int IdPizza{
            get{return _IdPizza;}
        }
        public string Nombre{
            get{return _Nombre;}
            set{_Nombre = value;}
        }
        public double Precio{
            get{return _Precio;}
            set{_Precio = value;}
        }
        public string Foto{
            get{return _UrlFoto;}
            set{_UrlFoto = value;}
        }
        public string Tamano{
            get{return _Tamano;}
            set{_Tamano = value;}
        }


    }
}