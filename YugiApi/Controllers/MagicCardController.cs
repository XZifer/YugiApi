using Microsoft.AspNetCore.Mvc;
using YugiApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YugiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicCardController : ControllerBase
    {
        Archivos archivos = new();
        List<MagicCard> Magias = new();
        // GET: api/<MagicCardController>
        [HttpGet]
        public List<MagicCard> Get()
        {
            Magias = archivos.Deserealizar("CartasMagia.json");
            return Magias;
        }

        // GET api/<MagicCardController>/5
        [HttpGet("{nombre}")]
        public MagicCard Get(string nombre)
        {
            Magias = archivos.Deserealizar("CartasMagia.json");
            MagicCard? cardexistente = Magias.FirstOrDefault(x => x.Nombre == nombre);
            return cardexistente;
        }

        // POST api/<MagicCardController>
        [HttpPost]
        public List<MagicCard> Post(MagicCard mc)
        {
            Magias = archivos.Deserealizar("CartasMagia.json");
            MagicCard? existe = Magias.FirstOrDefault(x => x.Nombre == mc.Nombre);
            if (existe == null)
            {
                Magias.Add(mc);
            }

            return Magias;
        }

        // PUT api/<MagicCardController>/5
        [HttpPut("{nombre}")]
        public List<MagicCard> Put(string nombre,MagicCard mcupdate)
        {
            Magias = archivos.Deserealizar("CartasMagia.json");
            MagicCard? mcexistente = Magias.FirstOrDefault(x => x.Nombre == nombre);
            MagicCard? mcduplicado = Magias.FirstOrDefault(x => x.Nombre == mcupdate.Nombre);
            if (mcexistente != null
                && mcupdate == null)
            {
                Magias.Remove(mcexistente);
                Magias.Add(mcupdate);
            }
            return Magias;
        }

        // DELETE api/<MagicCardController>/5
        [HttpDelete("{nombre}")]
        public List<MagicCard> Delete(string nombre)
        {
            MagicCard? mcexistente = Magias.FirstOrDefault(x => x.Nombre == nombre);
            if (mcexistente != null)
            {
                Magias.Remove(mcexistente);
            }
            return Magias;
        }
    }
}
