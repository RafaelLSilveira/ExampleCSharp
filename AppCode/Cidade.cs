using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{ 
    class Cidade : CIDADE
{
        public DataTable ListarTodas()
        {
            string sql = "select CODIGO, NOME + ' - '+ ESTADO as NOME from CIDADE ";
            sql = sql + "order by NOME";

            return OleDB.SQL.Select(sql);
        }


        public DataTable Pesquisar(string nome)
    {
        string sql = "select CODIGO, NOME, ESTADO from CIDADE ";
        sql = sql + "where NOME like '%{0}' ";
        sql = sql + "order by NOME";
        sql = string.Format(sql, nome);

        return OleDB.SQL.Select(sql);
    }

    public int Inserir()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("insert into CIDADE ");
        sb.Append("(NOME, ESTADO) ");
        sb.Append("values ");
        sb.AppendFormat("('{0}','{1}')", this.NOME, this.ESTADO);
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
        sb.Append("update CIDADE set ");
        sb.AppendFormat("NOME = '{0}', ", this.NOME);
        sb.AppendFormat("ESTADO = '{0}', ", this.ESTADO);
        sb.AppendFormat("where CODIGO = {0}", this.CODIGO);

        return OleDB.SQL.ExecuteNonQuery(sb.ToString());

    }// public int Alterar()
    public void Carregar(int codigo)
    {
        string sql = "select * from CIDADE where CODIGO = {0}";
        sql = String.Format(sql, codigo);

        DataTable dt = OleDB.SQL.Select(sql);

        this.CODIGO = int.Parse(dt.Rows[0]["CODIGO"].ToString());
        this.NOME = dt.Rows[0]["NOME"].ToString();
        this.ESTADO = dt.Rows[0]["ESTADO"].ToString();

    }//public void Carregar(int codigo)
}
}