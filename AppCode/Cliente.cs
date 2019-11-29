using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Cliente : CLIENTE
    {
        public DataTable Pesquisar(string nome, string telefone)
        {
            /* string sql = "select CODIGO, NOME, TELEFONE from CLIENTE ";
             sql = sql + "where NOME like '%{0}' ";
             sql = sql + "order by NOME";
             sql = string.Format(sql, nome);*/

            string sql = "select CODIGO, NOME, TELEFONE ";
            sql = sql + "from CLIENTE ";
            sql = sql + "where NOME like @NOME ";
            if (telefone.Trim().Length > 0)
            {
                sql = sql + " and TELEFONE like @TELEFONE ";
                telefone = "%" + telefone + "%";
            }
            sql = sql + "order by NOME";
            nome = "%"+nome+"%";
            string[] param = { "@NOME", "@TELEFONE" };
            string[] valores = { nome, telefone };
            DataTable dt = OleDB.SQL.Select(sql, param, valores);
            return dt;

            //return OleDB.SQL.Select(sql, "NOME", nome);
        }//public DataTable Pesquisar(string nome, string telefone)

        public int Inserir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into CLIENTE ");
            sb.Append("(NOME, TELEFONE, DATA_NASCIMENTO) ");
            sb.Append("values ");
            sb.AppendFormat("('{0}','{1}','{2}')", this.NOME,this.TELEFONE, this.DATA_NASCIMENTO);
            int resultado = OleDB.SQL.ExecuteNonQuery(sb.ToString());

            if (resultado == 1)
            {
                this.CODIGO = OleDB.SQL.GetLastIdentity();
                return 1;
            }
            else
            {
                return 0;
            }

        }// public int Inserir()

       
        public int Alterar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update CLIENTE set ");
            sb.AppendFormat("NOME = '{0}', ", this.NOME);
            sb.AppendFormat("TELEFONE = '{0}', ", this.TELEFONE);
            sb.AppendFormat("DATA_NASCIMENTO = '{0}' ", this.DATA_NASCIMENTO);
            sb.AppendFormat("where CODIGO = {0}", this.CODIGO);

            return OleDB.SQL.ExecuteNonQuery(sb.ToString());

        }
        public void Carregar(int codigo)
        {
            string sql = "select * from CLIENTE where CODIGO = {0}";
            sql = String.Format(sql, codigo);

            DataTable dt = OleDB.SQL.Select(sql);

            this.CODIGO = int.Parse(dt.Rows[0]["CODIGO"].ToString());
            this.NOME = dt.Rows[0]["NOME"].ToString();
            this.TELEFONE = dt.Rows[0]["TELEFONE"].ToString();
            this.DATA_NASCIMENTO = DateTime.Parse(dt.Rows[0]["DATA_NASCIMENTO"].ToString());

            
        }

    }
}
