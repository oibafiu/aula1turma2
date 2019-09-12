using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoComWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var i = 0;
           
            var nome = @"Pensando mais a longo prazo, a execução dos pontos do programa estimula a 
padronização dos modos de operação convencionais. O empenho em analisar a constante divulgação das informações
acarreta um processo de reformulação e modernização dos relacionamentos verticais entre as hierarquias. No entanto, 
não podemos esquecer que o fenômeno da Internet faz parte de um processo de gerenciamento dos níveis de motivação 
departamental. A certificação de metodologias que nos auxiliam a lidar com o entendimento das metas propostas apresenta
tendências no sentido de aprovar a manutenção do sistema de participação geral. Do mesmo modo,
o novo modelo estrutural aqui preconizado garante a contribuição de um grupo importante na determinação do fluxo de informações.";

            Console.WriteLine("Encontre a palavra");
            var palavra = Console.ReadLine();

            while (i < (nome.Length -1));
            {
                var palavraParaComparar = nome[i].ToString() +
                                           nome[i + 1].ToString() +
                                           nome[i + 2].ToString();
                                

                if (palavra == palavraParaComparar)
                    count++;

                i++;
            }

            Console.WriteLine($"Quantidade total de {palavra} {count}");
            Console.ReadLine();

            

                
        }

    }
    }

