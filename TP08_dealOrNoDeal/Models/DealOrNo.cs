using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dealOrNoDeal.Models
{
    public class DealOrNo
    {
        private static int _cantMaletines = 26;
        private static Maletin[] _maletines = new Maletin[_cantMaletines];
        private static int _maletinElegido;
        // private static int[] _importes = new int[] { 1, 5, 10, 15, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };     
        private const int _cantJugadas = 6;
        private static int _jugadasRestantes = _cantJugadas;

        private static Dictionary<int, string> _importeYNombre = new Dictionary<int,string>{
            {1,"Shiba"},
            {5,"Tron"},
            {10,"Dogecoin"},
            {15,"Stellar"},
            {25,"USDT"},
            {50,"IOTA"},
            {75,"Matic"},
            {100,"Ada"},
            {200,"XTZ"},
            {300,"PVU"},
            {400,"Pancake"},
            {500,"UNI"},
            {750,"Link"},
            {1000,"Terra"},
            {5000,"Ethereum Classic"} ,
            {10000,"Polkadot"},
            {25000,"Filecoin"},
            {50000,"Litecoin"},
            {75000,"Solana"},
            {100000,"Monero"},
            {200000,"BNB"},
            {300000,"AAVE"},
            {400000,"BCH"},
            {500000,"Maker"},
            {750000,"ETH"},
            {1000000,"Bitcoin"}
           };



        public Maletin[] Maletines{
            get{return _maletines;}
        }
        public int JugadasRestantes
        {
            get{return _jugadasRestantes;}
            set{_jugadasRestantes = value;}
        }
        
        public int CantJugadas{
            get{return _cantJugadas;}
        }

        public DealOrNo(int maletinElegido)
        {
            _maletinElegido = maletinElegido;
        }

        public string AbrirMaletin(int numero)
        {
            if (_maletines[numero - 1].Abierto)
            {
                return "-1";
            }
            else
            {
                _maletines[numero - 1].Abierto = true; //te la abrieron bb
                _jugadasRestantes-=1;
                Console.WriteLine("JUGADAS RESTANTES MODEL: " + _jugadasRestantes.ToString());
                return _maletines[numero - 1].NombreCripto;
            }
        }
        public int OfertaBanca()
        {
            int total = 0;
            int contador = 0;
            Console.WriteLine("JUGADAS RESTANTES DEALORNO: " + _cantJugadas.ToString());
            double oferta = -1;

            if (_jugadasRestantes == 0)
            {
                for (int i = 0; i < _cantMaletines; i++)
                {
                    if (_maletines[i].Abierto)
                    {
                        continue;
                    }
                    total += _maletines[i].Importe;
                    contador++;
                    
                }
                oferta = total / contador * 0.85;
                
            }
            return Convert.ToInt32(oferta);
        }

        public int DecisionOferta(bool Aceptar)
        {
            if (!Aceptar)
            {
                _jugadasRestantes = _cantJugadas;
                return -1;
            }
            else
            {
                return _maletines[_maletinElegido].Importe;
            }
        }

        public int DecisionDosMaletines(int eligioElSuyo)
        {
           Console.WriteLine("MALETIN ELEGIDO ULTIMO: " + eligioElSuyo.ToString());
            return _maletines[eligioElSuyo-1].Importe;
            
        }

        public void IniciarJuego(int maletinElegido)
        {
            Console.WriteLine("INICIOOOOO");
            var random = new Random();
            Random rand = new Random();
            List<int> importesShuffle = new List<int>();
            Dictionary<int, string> dictShuffle = _importeYNombre.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
            foreach(var item in dictShuffle){
                importesShuffle.Add(item.Key);
            }
            for (int i = 0; i < _cantMaletines; i++)
            {
                // Console.WriteLine(i.ToString() + ": " + _importesRandom[i].ToString());
                _maletines[i] = new Maletin(i+1, importesShuffle[i], dictShuffle[importesShuffle[i]]);
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8; // para la carita fachera
            Console.WriteLine("---------------- 😎 ----------------");
            _maletines[maletinElegido-1].Elegido = true;
            for (int i = 0; i < _cantMaletines; i++)
            {
                Console.WriteLine(_maletines[i].Numero.ToString() + ": " + _maletines[i].Importe.ToString() + " " + _maletines[i].NombreCripto.ToString() + " - " + _maletines[i].Elegido.ToString());
            }  
        }
        
        public Maletin[] DevolverListaMaletines(){
            return _maletines;
        }

        public int[] DevolverListaImportes(){
            List<int> importe = new List<int>();
            foreach(var (key,value) in _importeYNombre){
                importe.Add(key);
            }
            return importe.ToArray();
        }
    }
}