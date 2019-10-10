using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores.Model
{
    public class Flores
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
