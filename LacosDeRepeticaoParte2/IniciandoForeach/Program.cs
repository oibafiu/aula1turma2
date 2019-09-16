﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForeachComSplit();
            //ForeachComSplitLista();
            InformacoesCarro();
        }
        /// <summary>
        /// Metodo  que mostra como podemos utilizar o foreach para andar sobre um array 
        /// de caracteres, ou seja um texto ou palavra etc...
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {

                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui eu digito meu nome Fabio para realizar a busca";

            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso");
            }
            Console.ReadKey();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo =
                "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
           
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach(var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];



                if(nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
                Console.ReadKey();
            }
            
          
        }
        /// <summary>
        /// Esse metodo busca a informações do carro e tras o ano e a marca
        /// </summary>
        private static void InformacoesCarro()
        {
            var conteudo = "carro:Gol,ano:2016,marca:Volkswagen;carro:HB20,ano:2019,marca:Hyunday";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Carros cadastrados no sistema");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
              
            }
            Console.WriteLine("Informe um carro do sistema:");
            var carroBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var carro = informacoesSplit[0].Split(':')[1];
                var ano = informacoesSplit[1].Split(':')[1];
                var marca = informacoesSplit[2].Split(':')[1];


                if (carro == carroBusca)
                {
                    Console.WriteLine($"O {carro} é da  {marca} e é do ano {ano}.");
                }
                Console.ReadKey();
            }


        }


    }

        }


            
    

