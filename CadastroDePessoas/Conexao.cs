using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class Conexao
    {
        //PARA CONECTAR O BANCO PRECISO DESSA CONEXAO DECLARADA
        SqlConnection con = new SqlConnection();



        // CONSTRUTOR
        public Conexao()
        {
            con.ConnectionString = @" aqui vai a connection string do banco de dados - TENHO QUE COLOCAR O @ NA FRENTE DAS ASPAS PARA ELE RECONHECER AS BARRAS CONTRARIAS ";

        }
        
        
        
        // METODO PARA CONECTAR AO BANCO
        public SqlConnection conectar()
        {
            // PARA CONECTAR AO BANCO FAÇO A PERGUNTA SE ESTA CONECTADO OU NÃO
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }



        // METODO PARA DESCONECTAR DO BANCO

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
           
        }


    }
}
