﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Livro> Livros { get; set; }
      
        
    }
}
