using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesteCSharp
{
    public class Conexao
    {
        NpgsqlConnection con = new NpgsqlConnection();
        public Conexao()
        {
            con.ConnectionString = "Host=no-db-dev-101.negocieonline.com.br;Username=test;Password=Sacapp@2020;Database=db_selecao_imdb";
        }

        public NpgsqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) con.Open();
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open) con.Close();

        }
    }
}


