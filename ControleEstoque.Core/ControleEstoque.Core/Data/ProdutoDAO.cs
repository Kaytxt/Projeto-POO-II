using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoque.Core.Models;
using Npgsql;

namespace ControleEstoque.Core.Data
{
    public class ProdutoDAO
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Database=estoque_db;Username=postgres;Password=Kauansimone@1";

        public void Cadastrar(Produto produto)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var sql = "INSERT INTO produtos (nome, preco, quantidade) VALUES (@nome, @preco, @quantidade)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", produto.Nome);
                    cmd.Parameters.AddWithValue("preco", produto.Preco);
                    cmd.Parameters.AddWithValue("quantidade", produto.Quantidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarQuantidade(int idProduto, int quantidade)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Comando SQL para atualizar a quantidade do produto.
                // Usamos 'WHERE id_produto = @id' para garantir que apenas o produto correto seja alterado.
                var sql = "UPDATE produtos SET quantidade = quantidade + @quantidade WHERE id_produto = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", idProduto);
                    cmd.Parameters.AddWithValue("quantidade", quantidade);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Produto produto)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Comando SQL para atualizar o produto com todos os seus dados.
                // A cláusula WHERE é fundamental para editar apenas o produto correto.
                var sql = "UPDATE produtos SET nome = @nome, preco = @preco, quantidade = @quantidade WHERE id_produto = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Atribui os novos valores do objeto Produto aos parâmetros
                    cmd.Parameters.AddWithValue("id", produto.Id);
                    cmd.Parameters.AddWithValue("nome", produto.Nome);
                    cmd.Parameters.AddWithValue("preco", produto.Preco);
                    cmd.Parameters.AddWithValue("quantidade", produto.Quantidade);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int idProduto)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Comando SQL para deletar um produto pelo seu ID.
                // A cláusula WHERE é fundamental para excluir apenas o produto correto.
                var sql = "DELETE FROM produtos WHERE id_produto = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", idProduto);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Produto> ListarTodos()
        {
            var produtos = new List<Produto>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Comando SQL para selecionar todos os registros da tabela 'produtos'.
                var sql = "SELECT id_produto, nome, preco, quantidade FROM produtos ORDER BY id_produto ASC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // 'ExecuteReader' é usado para comandos que retornam dados (SELECT).
                    using (var reader = cmd.ExecuteReader())
                    {
                        // 'reader.Read()' retorna verdadeiro se houver mais linhas para ler.
                        while (reader.Read())
                        {
                            var produto = new Produto
                            {
                                // 'reader' lê os dados do banco e os atribui às propriedades do objeto Produto.
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Preco = reader.GetDecimal(2),
                                Quantidade = reader.GetInt32(3)
                            };

                            produtos.Add(produto);
                        }
                    }
                }
            }

            return produtos;
        }
    }
}
