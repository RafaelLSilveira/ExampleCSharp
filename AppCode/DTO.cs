using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    /*
     * Classes usadas para fazer mapeamento OBJETO-RELACIONAL 
     */
    class CLIENTE
    {
        public int CODIGO { get; set; }
        public string NOME { get; set; }
        public string TELEFONE { get; set; }
        public DateTime? DATA_NASCIMENTO { get; set; }
    }
    class CIDADE
    {
        public int CODIGO { get; set; }
        public string NOME { get; set; }
        public string ESTADO { get; set; }
    }
}
