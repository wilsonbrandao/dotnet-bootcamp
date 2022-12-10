using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoAPI.Context;
using IntroducaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroducaoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost("/Contato")]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
        }

        [HttpGet("/Contato/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null) return NotFound();

            return Ok(contato);
        }

        [HttpGet("/Contato/ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            if (contatos == null) return NotFound();

            return Ok(contatos);
        }

        [HttpPut("/Contato/{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone; ;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);

        }

        [HttpDelete("/Contato/{id}")]
        public IActionResult Delete(int id)
        {

            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return NoContent();
        }



    }
}