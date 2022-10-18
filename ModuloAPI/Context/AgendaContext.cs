using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
  //representa o banco de d
    public class AgendaContext : DbContext
    {
        //recebe a conexão do banco e passa para o DbContext
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        //recebe uma entidade (Tabela)
        public DbSet<Contato> Contatos { get; set; }

    }
}