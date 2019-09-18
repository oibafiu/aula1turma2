using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// METODO PARA RETORNAR A AREA DE UM QUADRADO
        /// </summary>
        /// <param name="ladoDoQuadrado">lADO DO QUADRADO COM PRECISÃO INTEIRA</param>
        /// <returns>RETORNA A ÁREA TOTAL DO QUADRADO</returns>
        public int CalculaAreaDoQuadrado(int ladoDoQuadrado)
        {
            return ladoDoQuadrado * ladoDoQuadrado;
        }

    }
}
