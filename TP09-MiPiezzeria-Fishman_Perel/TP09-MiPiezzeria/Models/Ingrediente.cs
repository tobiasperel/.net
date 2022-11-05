using System;
using System.Collections.Generic;


namespace TP09_MiPiezzeria.Models
{
    public class Ingrediente
    {
        private static int IdCount = 0;
        private int _IdIngrediente;
        private string _Nombre;
        private string _UrlFoto;

        public Ingrediente(string Nombre, string UrlFoto){
            _IdIngrediente = IdCount;
            _Nombre = Nombre;
            _UrlFoto = UrlFoto;
            IdCount++;
        }

        public int idIngredientes{
            get{return _IdIngrediente;}
        }
        public string Nombre{
            get{return _Nombre;}
        }
        public string Foto{
            get{return _UrlFoto;}
        }
    }
    
}