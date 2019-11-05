using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(i => i.Ativo == true);
        }
        /// <summary>
        /// Metodo que atualiza um registro valido no nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.FirstOrDefault(i => i.Id == item.Id);

            if (celular == null)
                return false;
            else
            {
              

                celular.DataAlteracao = DateTime.Now;
            }
                
            contextDB.SaveChanges();

            return true;
        }
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0) return false;

            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();

            return true;
        }
        /// <summary>
        /// Metodo utilizado para apenas desativar o item dentro do nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativr</param>
        /// <returns>Retorna verdadeira em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(i => i.Id == id);

            if (celular == null)
                return false;

            celular.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }
    }
}
