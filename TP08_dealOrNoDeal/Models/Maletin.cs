using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dealOrNoDeal.Models
{
    public class Maletin
    {
        private int _importe;
        private int _numero;
        private string _color;
        private bool _abierto;
        private bool _elegido;
        private string _nombreCripto;

        public Maletin(int numero, int importe, string nombreCripto)
        {
            _importe = importe;
            _numero = numero;
            _nombreCripto = nombreCripto;
            _color = "default";
            _abierto = false;
            _elegido = false;
        }

        public bool Abierto
        { get { return _abierto; } set { _abierto = value; } }

        public int Importe
        { get { return _importe; } }

        public string NombreCripto
        { get{ return _nombreCripto; } }

        public int Numero
        { get { return _numero; } }
        public bool Elegido
        { get { return _elegido; } set{_elegido = value;}}
    }
}