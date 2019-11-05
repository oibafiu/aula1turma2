using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui Carregamos nessa caixa de ferramentas de pessoas 
            //podemos agora listar e demais funcionalidades
            PessoaController pessoaController = 
                //Nessa parte ao iniciar na memória, iniciamos o construtor
                new PessoaController();
            //Usamos o foreach do linq para percorrer a lista de pessoas. Criamos a variavel
            //i para receber o item da nossa lista. Imprimimos a informação de cada item da nossa lista.
            pessoaController.ListaPessoasPublica.ForEach(pessoa => MostraInformacoes(pessoa));

            MostraIdentificador("Lista Ordenada");
            pessoaController.GetPessoasOrdenadaAsc().ForEach(pessoa => MostraInformacoes(pessoa));
            Console.WriteLine("-----------------------------");
            pessoaController.GetPessoasOrdenadaDataNasc().ForEach(i => MostraInformacoes(i));
            Console.WriteLine("------------------------------");
            pessoaController.GetPessoasOrdenadaDinheiro().ForEach(i => MostraInformacoes(i));
            Console.WriteLine("------------------------------");
            pessoaController.GetPessoasMaioresDeIdade().ForEach(i => MostraInformacoes(i));
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra no console formatado nosso objeto "Pessoa"
        /// </summary>
        /// <param name="pessoa">Objeto pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Nosso template que apresenta as informações 
            string template = "ID={0,3} || Nome ={1,10} || Data de Nascimento = {2,10} || Carteira =  {3,5} ||";
            //Recebemos as informações com o string format (string format) é usado para formatar a string e deixar 
            //o texto apresentavel
            string textoFormatado = string.Format(template, pessoa.Id, pessoa.Nome, pessoa.DataNascimento.ToShortDateString(), pessoa.Carteira.ToString("C2"));



            Console.WriteLine(textoFormatado);
        }
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("--------{0,20} ---------", nomeAcao));
        }
    }
}
