using System;
using System.Collections.Generic;

namespace YugiohTCG.Modelos.Modelos.DB
{
    public partial class TrapCard
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Atributo { get; set; }
        public string? Icono { get; set; }
        public string? Duracion { get; set; }
        public string? Velocidad { get; set; }
        public string? Carta { get; set; }
        public string? Descripcion { get; set; }
    }
}
