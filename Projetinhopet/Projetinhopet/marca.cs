using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Projetinhopet
{
    class marca
    {
        int cpf;
        DateTime data;
        int horario;

        public void marcahora()
        {

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=projetinho;uid=root");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel conectar-se ao banco");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;//cmd pode ser qualquer 

            Console.WriteLine("Digite o seu CPF");
            string cpf;
            cpf = Console.ReadLine();
            Console.WriteLine("Digite a Data da consulta: {0}", cpf);
            DateTime data;
            data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite o horario da consulta: {0}", cpf);
            int horario;
            horario = int.Parse(Console.ReadLine());
       


            string sql;
            sql = "insert into consulta values(@cpf, @data, @horario)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@horario", horario);
            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();

        }
    }
}
