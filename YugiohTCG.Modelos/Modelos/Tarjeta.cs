using YugiohTCG.Modelos.Enum;

namespace YugiohTCG.Modelos.Modelos
{
    public class Tarjeta
    {
        public string Nombre { get; set; }
        public TipoCarta Carta { get; set; }
        public string Atributo { get; set; }
        public string Descripcion { get; set; }
    }
}
