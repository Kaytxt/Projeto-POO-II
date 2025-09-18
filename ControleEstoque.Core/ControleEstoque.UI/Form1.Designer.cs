

namespace ControleEstoque.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nome = new Label();
            Preço = new Label();
            Quantidade = new Label();
            textBoxQuantidade = new TextBox();
            textBoxPreco = new TextBox();
            textBoxNome = new TextBox();
            buttonCadastrar = new Button();
            labelStatus = new Label();
            label1 = new Label();
            textBoxId = new TextBox();
            dataGridViewProdutos = new DataGridView();
            buttonListar = new Button();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(108, 144);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            Nome.Click += label1_Click;
            // 
            // Preço
            // 
            Preço.AutoSize = true;
            Preço.Location = new Point(108, 186);
            Preço.Name = "Preço";
            Preço.Size = new Size(37, 15);
            Preço.TabIndex = 1;
            Preço.Text = "Preço";
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Location = new Point(108, 226);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(69, 15);
            Quantidade.TabIndex = 2;
            Quantidade.Text = "Quantidade";
            Quantidade.Click += label3_Click;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(216, 223);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(100, 23);
            textBoxQuantidade.TabIndex = 3;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(216, 183);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(100, 23);
            textBoxPreco.TabIndex = 4;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(216, 141);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 5;
            textBoxNome.TextChanged += textBox3_TextChanged;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(59, 283);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(113, 351);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(64, 15);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "labelStatus";
            labelStatus.Visible = false;
            labelStatus.VisibleChanged += buttonCadastrar_Click;
            labelStatus.Click += labelStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 106);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 10;
            label1.Text = "ID do Produto";
            label1.Click += label1_Click_1;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(216, 103);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 11;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(419, 30);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(472, 390);
            dataGridViewProdutos.TabIndex = 12;
            dataGridViewProdutos.CellClick += dataGridViewProdutos_CellClick;
            // 
            // buttonListar
            // 
            buttonListar.Location = new Point(310, 283);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(75, 23);
            buttonListar.TabIndex = 13;
            buttonListar.Text = "Listar Produtos";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(229, 283);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 14;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(140, 283);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 15;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 473);
            Controls.Add(buttonEditar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonListar);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(labelStatus);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxQuantidade);
            Controls.Add(Quantidade);
            Controls.Add(Preço);
            Controls.Add(Nome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Preço;
        private Label Quantidade;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPreco;
        private TextBox textBoxNome;
        private Button buttonCadastrar;
        private Label labelStatus;
        private Label label1;
        private TextBox textBoxId;
        private DataGridView dataGridViewProdutos;
        private Button buttonListar;
        private Button buttonExcluir;
        private Button buttonEditar;
    }
}
