using ListandoPessoas2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas2.Controller
{
    public class PessoaController
    {
        /// <summary>
        /// Lista que contem as pessoas para realizar as atividades
        /// </summary>
        private List<Pessoa> listaDePessoas { get; set; }
        /// <summary>
        /// O metodo construtor ajuda a iniciar nossa classe para utilizarmos
        /// de maneira correta as informações internas, com isso podemos iniciar
        /// nossa lista de pessoas sem depender do usuario ou programador na parte da interface
        /// </summary>
        public PessoaController()
        {
            //Iniciamos a lista de pessoas dentro do nosso metodo construtor
            listaDePessoas = new List<Pessoa>();

            listaDePessoas.Add(new Pessoa() { Id = 1, Nome = "Spears  ", DataNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            listaDePessoas.Add(new Pessoa() { Id = 2, Nome = "Swanson  ", DataNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            listaDePessoas.Add(new Pessoa() { Id = 3, Nome = "Gay      ", DataNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            listaDePessoas.Add(new Pessoa() { Id = 4, Nome = "Gregory  ", DataNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            listaDePessoas.Add(new Pessoa() { Id = 5, Nome = "Olson    ", DataNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            listaDePessoas.Add(new Pessoa() { Id = 6, Nome = "Garza    ", DataNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            listaDePessoas.Add(new Pessoa() { Id = 7, Nome = "Sweet    ", DataNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            listaDePessoas.Add(new Pessoa() { Id = 8, Nome = "Cline    ", DataNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            listaDePessoas.Add(new Pessoa() { Id = 9, Nome = "Oliver   ", DataNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            listaDePessoas.Add(new Pessoa() { Id = 10, Nome = "Vang     ", DataNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            listaDePessoas.Add(new Pessoa() { Id = 11, Nome = "Maddox   ", DataNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            listaDePessoas.Add(new Pessoa() { Id = 12, Nome = "Garrett  ", DataNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            listaDePessoas.Add(new Pessoa() { Id = 13, Nome = "Mcintosh ", DataNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            listaDePessoas.Add(new Pessoa() { Id = 14, Nome = "Yang     ", DataNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            listaDePessoas.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            listaDePessoas.Add(new Pessoa() { Id = 16, Nome = "Cain     ", DataNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            listaDePessoas.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            listaDePessoas.Add(new Pessoa() { Id = 18, Nome = "Howe     ", DataNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            listaDePessoas.Add(new Pessoa() { Id = 19, Nome = "Pratt    ", DataNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            listaDePessoas.Add(new Pessoa() { Id = 20, Nome = "Sherman  ", DataNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });

        }
        /// <summary>
        /// Temos uma propriedade agora que nos retorna nossa lista
        /// com essa propriedade temos a lista completa e sem regras 
        /// da lista de pessoas, mas ao liberar somente o GET
        /// não damos acesso para alterar fora da classe a lista
        /// apenas a visualização
        /// </summary>
        public List<Pessoa> ListaPessoasPublica
        {
            get { return listaDePessoas; }
        }
        /// <summary>
        /// Metodo que retorna nossa lista de pessoas ordenadas de forma asc pelo nome de cada uma
        /// </summary>
        /// <returns>Retornamos o valor já ordenado da nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadaAsc()
        {
            //Aqui temos nossa lista de pessoas, e ordenamos ela por ordem.
            return listaDePessoas.OrderBy(i => i.Nome).ToList<Pessoa>();
        }
        public List<Pessoa> GetPessoasOrdenadaDataNasc()
        {
            return listaDePessoas.OrderByDescending(i => i.DataNascimento).ToList<Pessoa>();
        }
        public List<Pessoa> GetPessoasOrdenadaDinheiro(double valor = 500)
        {
            return listaDePessoas.FindAll(i => i.Carteira > valor).OrderBy(i => i.Carteira).ToList<Pessoa>();
        }
        public List<Pessoa> GetPessoasMaioresDeIdade(int idade = 18)
        {
            return listaDePessoas.FindAll(i => (DateTime.Now.Year - i.DataNascimento.Year) > idade);
        }
        public List<Pessoa> GetPessoasMenoresDeIdade(int idade = 16)
        {
            return listaDePessoas.FindAll(i => (DateTime.Now.Year - i.DataNascimento.Year) < 16);
        }

    }
}

