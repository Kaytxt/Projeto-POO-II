
using ControleEstoque.Core.Data;
using ControleEstoque.Core.Models;
using Npgsql;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleEstoque.UI
{
    public partial class Form1 : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var produto = new Produto
                {
                    // Obtém os valores dos campos de texto
                    Nome = textBoxNome.Text,
                    Preco = decimal.Parse(textBoxPreco.Text),
                    Quantidade = int.Parse(textBoxQuantidade.Text)
                };

                // Chama o método da nossa camada de dados
                produtoDAO.Cadastrar(produto);

                // Exibe mensagem de sucesso
                labelStatus.Visible = true;
                labelStatus.Text = "Produto cadastrado com sucesso!";
                labelStatus.ForeColor = System.Drawing.Color.Green;

                // Limpa os campos após o cadastro
                textBoxNome.Clear();
                textBoxPreco.Clear();
                textBoxQuantidade.Clear();
            }
            catch (FormatException)
            {
                // Trata o erro se o usuário digitar algo que não é um número
                labelStatus.Text = "Erro: Preço e quantidade devem ser números válidos.";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                // Trata outros erros (ex: falha na conexão com o banco)
                labelStatus.Text = "Erro ao cadastrar: " + ex.Message;
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                // Chama o método da camada de dados para buscar a lista de produtos.
                var listaDeProdutos = produtoDAO.ListarTodos();

                // Atribui a lista de produtos como a fonte de dados do DataGridView.
                dataGridViewProdutos.DataSource = listaDeProdutos;

                labelStatus.Text = "Produtos listados com sucesso!";
                labelStatus.ForeColor = System.Drawing.Color.Blue;
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao listar produtos: " + ex.Message;
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida (não no cabeçalho das colunas)
            if (e.RowIndex >= 0)
            {
                // Pega a linha completa que foi clicada
                DataGridViewRow linhaSelecionada = dataGridViewProdutos.Rows[e.RowIndex];

                // Obtém os dados de cada célula da linha e os atribui aos campos de texto
                textBoxId.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                textBoxNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                textBoxPreco.Text = linhaSelecionada.Cells["Preco"].Value.ToString();
                textBoxQuantidade.Text = linhaSelecionada.Cells["Quantidade"].Value.ToString();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega o ID do campo de texto
                int idProduto = int.Parse(textBoxId.Text);

                // Chama o método da nossa camada de dados para excluir o produto
                produtoDAO.Excluir(idProduto);

                // Exibe uma mensagem de sucesso
                labelStatus.Text = $"Produto ID {idProduto} excluído com sucesso!";
                labelStatus.ForeColor = System.Drawing.Color.Green;

                // Limpa os campos após a exclusão e atualiza a lista
                textBoxId.Clear();
                textBoxNome.Clear();
                textBoxPreco.Clear();
                textBoxQuantidade.Clear();

                // Chama o método para listar os produtos novamente e atualizar a tabela
                buttonListar_Click(null, null);
            }
            catch (FormatException)
            {
                labelStatus.Text = "Erro: O ID do produto deve ser um número inteiro.";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao excluir: " + ex.Message;
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto Produto com os novos dados dos campos
                var produto = new Produto
                {
                    Id = int.Parse(textBoxId.Text),
                    Nome = textBoxNome.Text,
                    Preco = decimal.Parse(textBoxPreco.Text),
                    Quantidade = int.Parse(textBoxQuantidade.Text)
                };

                // Chama o método da camada de dados para atualizar o produto
                produtoDAO.Editar(produto);

                // Exibe mensagem de sucesso
                labelStatus.Text = $"Produto ID {produto.Id} editado com sucesso!";
                labelStatus.ForeColor = System.Drawing.Color.Green;

                // Limpa os campos e atualiza a lista
                textBoxId.Clear();
                textBoxNome.Clear();
                textBoxPreco.Clear();
                textBoxQuantidade.Clear();

                buttonListar_Click(null, null);
            }
            catch (FormatException)
            {
                labelStatus.Text = "Erro: Por favor, preencha todos os campos com valores válidos.";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao editar: " + ex.Message;
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}