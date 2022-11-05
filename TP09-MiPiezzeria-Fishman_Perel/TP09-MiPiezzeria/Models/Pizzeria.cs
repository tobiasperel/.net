using System;
using System.Collections.Generic;

namespace TP09_MiPiezzeria.Models
{
    public class Pizzeria
    {
        private static List<Pizza> _ListaPizza = new List<Pizza>();
        private static List<Ingrediente> _ListaIngredientes = new List<Ingrediente>();

        public static List<Ingrediente> ListarIngredientes(){
            return _ListaIngredientes;
        }

        public static List<Pizza> ListarPizzas(){
            return _ListaPizza;
        }

        public static bool EliminarPizza(Pizza UnaPizza){
            if(_ListaPizza.Contains(UnaPizza)){
                _ListaPizza.Remove(UnaPizza);
                return true;
            }
            return false;
        }

        public static bool AgregarPizza(Pizza UnaPizza){
            try
            {
                 _ListaPizza.Add(UnaPizza);
                 return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }

    }
}   