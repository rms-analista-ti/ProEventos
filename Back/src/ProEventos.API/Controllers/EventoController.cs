using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema =  "Angular", 
                Local = "teste",
                Lote = "1",
                QtdPessoas = 20,
                ImagemURL = "foto.png",
                DataEvento = DateTime.Now.AddDays(2).ToString()
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
            return _evento.Where(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post(){
            return "Exemplo POST";
        }
        [HttpPut("{id}")]
        public string Put(int id){
            return $"Exemplo de Put com ID = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Exemplo de Delete com ID = {id}";
        }
    }
}
