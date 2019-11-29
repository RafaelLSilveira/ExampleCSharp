using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace OleDB {
   public static class DB {
      private static OleDbConnection conexao;
      public static OleDbConnection Connection { get { return Open(); } }
      //instancia e abre a conexao
      public static OleDbConnection Open() {
         if (conexao == null) {
            conexao = new OleDbConnection();
            conexao.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
	  	                                 @"Data Source=E:\cliente.mdb;";
            try {
               conexao.Open();
               return conexao;
            }
            catch {
               return null;
            }
         }
         else {
            return conexao;
         }
      }//public static OleDbConnection Conectar()

      //fecha a conexao
      public static void Fechar() {
         conexao.Close();
      }
   }//public static class OleDB 

   public static class SQL {
      public static DataTable Select(string sql) {
         OleDbCommand cmd = new OleDbCommand(sql, DB.Connection);
         OleDbDataAdapter da = new OleDbDataAdapter(cmd);
		 //DataTable permite armazenar os dados resultantes de um SELECT (bidirecional)
         DataTable dt = new DataTable();
         try {
			//preenche o DataTable 
            da.Fill(dt);
         }
         catch {
            return null;
         }
         return dt;
      }//public static DataTable Select(string sql)

        public static DataTable Select(string sql, string [] parametros, string [] valores)
        {
            OleDbCommand cmd = new OleDbCommand(sql, DB.Connection);
            for (int i=0; i < parametros.Length; i++)
            {
                cmd.Parameters.Add(new OleDbParameter(parametros[i], valores[i]));
            }
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //DataTable permite armazenar os dados resultantes de um SELECT (bidirecional)
            DataTable dt = new DataTable();
            try
            {
                //preenche o DataTable 
                da.Fill(dt);
            }
            catch
            {
                return null;
            }
            return dt;
        }//

        public static OleDbDataReader ExecuteReader(string sql) {
         OleDbCommand cmd = new OleDbCommand(sql, DB.Connection);
         OleDbDataReader rd;
         try {
            rd = cmd.ExecuteReader();
         }
         catch {
            return null;
         }
         return rd;
      }//public static OleDbDataReaderr ExecuteReader(string sql) 

      public static Object ExecuteScalar(string sql) {
         OleDbCommand cmd = new OleDbCommand(sql, DB.Connection);
         Object obj;
         try {
            obj = cmd.ExecuteScalar();
         }
         catch {
            return null;
         }

         return obj;
      }//public static Object ExecuteScalar(string sql)


      public static int ExecuteNonQuery(string sql) {
         OleDbCommand cmd = new OleDbCommand(sql, DB.Connection);
         int i;
         try {
            i = cmd.ExecuteNonQuery();
         }
         catch (Exception erro) {
                //ExecuteNonQuery retorna o número de linhas afetadas
                //ZERO significa que nenhuma linha foi afetada, mas o comando era válido
                //aqui retorna -1 para mostrar que o comando continha erro(s)
                
            return -1;
         }
         return i;
      }//public static int ExecuteNonQuery(string sql)
        public static int GetLastIdentity()
        {
            string sql = "SELECT @@Identity";
            return int.Parse(SQL.ExecuteScalar(sql).ToString());
        }
   } //public static class SQL
}//namespace Northwind
