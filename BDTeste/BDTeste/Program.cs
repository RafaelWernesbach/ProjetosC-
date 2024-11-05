using Microsoft.Data.SqlClient;

namespace BDTeste
{
    internal class Program
    {

        private static void Salvar(SqlConnection conexao, Departamento dep)
        {
            Console.WriteLine("Salvando o autor");

            var cmd = conexao.CreateCommand();
            cmd.CommandText = "INSERT INTO DEPARTAMENTO (NOME) VALUES (@nome)";

            var param = new SqlParameter("nome", dep.Nome);
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
        }
        static void Main(string[] args)
        {

            SqlConnection? conexao = null;

            string url = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MeuBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                conexao = new(url);
                conexao.Open();
                Console.WriteLine("Status: CONEXÃO OK");
            }
            catch (Exception)
            {
                Console.WriteLine("Status: CONEXÃO FALHOU");
            }
            if (conexao != null)
            {
                Departamento dep = new Departamento("vendas");
                Salvar(conexao, dep);
            }

        }
    }
}
