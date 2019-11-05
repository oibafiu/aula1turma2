using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtividadeFinal.Models
{
    public partial class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
