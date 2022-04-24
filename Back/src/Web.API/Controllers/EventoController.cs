using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.API.Models;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e  .Net 5",
                    Local = "BH",
                    Lote = "1 Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "VAZIO"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e  .Net 5",
                    Local = "SP",
                    Lote = "2 Lote",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(5).ToString(),
                    ImagemURL = "VAZIO"
                }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Return Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Return Put " + id;
        }

        [HttpDelete("{id}")]
        public string DeletHttpDelete(int id)
        {
            return "Return Delete " + id;
        }
    }
}
