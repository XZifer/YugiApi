using System;
using System.Collections.Generic;

namespace YugiohTCG.Modelos.Modelos.DB
{
    public partial class MonsterCard
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public string? Atributo { get; set; }
        public int? Nivel { get; set; }
        public string? Carta { get; set; }
        public int? Ataque { get; set; }
        public int? Defensa { get; set; }
        public string? Descripcion { get; set; }
    }
}
