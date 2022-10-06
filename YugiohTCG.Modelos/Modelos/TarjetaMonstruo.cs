using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YugiohTCG.Modelos.Modelos
{
    public class TarjetaMonstruo : Tarjeta
    {
        public int Nivel { get; set; }
        public string Tipo { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
    }
}
