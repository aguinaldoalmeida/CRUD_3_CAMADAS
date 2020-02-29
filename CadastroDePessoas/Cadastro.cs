using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class Cadastro
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;



        public Cadastro  (String nome, String telefone)
            {
            // COMANDO SQL INSERT / DELETE / UPDATE - USAMOS SQLCommand.text -- ou comando na forma de texto
            cmd.CommandText = "insert into nome da tabela (nome , telefone) values (@nome, @telefone)"; // NECESSÁRIO COLOCAR ARROBA NOS CAMPOS POR CAUSA DAS ASPAS

            // PARAMETROS -- PASSO DOIS VALORES QUE QUERO MUDAR NA TABELA
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);


            // CONECTAR COM  O BANCO DE DADOS
            //USO O TRY PORQUE CASO OCORRA ERRO CAI NESSE TRATAMENTO
            try
            {
                cmd.Connection = conexao.conectar();
                // EXECUTAR O COMANDO SE FOR INSERT || DELETE || UPDATE
                //ExecuteNonRead TRAS OS DADOS PARA  A APLICAÇÃO -- COMO EU VOU SOMENTE ENVIAR OS DADOS ENTÃO USO ExecuteNonQuery
                cmd.ExecuteNonQuery();

                // DESCONECTAR COM O BANCO
                conexao.desconectar();

                // MESAGEM DE ERRO OU SUCESSO -- string mensagem
                this.mensagem = "Dados confirmados com sucesso !";

            }
            catch (SqlException e)
            {
                //USO A VARIAVEL e  ACIMA PARA GUARDAR O ERRO ESPECÍFICO
                this.mensagem ="Erro na conexão !";
                throw;
            }


               
                
               
            }
    }
}
