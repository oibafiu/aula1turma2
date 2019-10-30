using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImoveisApi.Models
{
    public class UsuarioContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Imovel> Imoveis { get; set; }
    }
}