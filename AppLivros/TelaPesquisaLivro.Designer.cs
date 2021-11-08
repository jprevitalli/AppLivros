
namespace AppLivros
{
    partial class TelaPesquisaLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tBoxPaginas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPickerLivro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxEditora = new System.Windows.Forms.TextBox();
            this.tBoxAutor = new System.Windows.Forms.TextBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbCodigoLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPesqTodosLivro = new System.Windows.Forms.Button();
            this.dataGridViewLivro = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(75, 65);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 449);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tBoxPaginas);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dTPickerLivro);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tBoxEditora);
            this.tabPage1.Controls.Add(this.tBoxAutor);
            this.tabPage1.Controls.Add(this.tBoxNome);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.tbCodigoLivro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBusca);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(930, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tBoxPaginas
            // 
            this.tBoxPaginas.Location = new System.Drawing.Point(715, 224);
            this.tBoxPaginas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxPaginas.Name = "tBoxPaginas";
            this.tBoxPaginas.Size = new System.Drawing.Size(171, 22);
            this.tBoxPaginas.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Páginas do Livro:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Romance",
            "Ficção Literária",
            "Não-Ficção",
            "Ficção Científica",
            "Suspense",
            "Fantasia",
            "Horror",
            "Poesia",
            "Educacional"});
            this.listBox1.Location = new System.Drawing.Point(237, 278);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 116);
            this.listBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Gênero:";
            // 
            // dTPickerLivro
            // 
            this.dTPickerLivro.CustomFormat = "";
            this.dTPickerLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerLivro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerLivro.Location = new System.Drawing.Point(237, 224);
            this.dTPickerLivro.Margin = new System.Windows.Forms.Padding(4);
            this.dTPickerLivro.Name = "dTPickerLivro";
            this.dTPickerLivro.Size = new System.Drawing.Size(171, 29);
            this.dTPickerLivro.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ano do Livro:";
            // 
            // tBoxEditora
            // 
            this.tBoxEditora.Location = new System.Drawing.Point(235, 175);
            this.tBoxEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxEditora.Name = "tBoxEditora";
            this.tBoxEditora.Size = new System.Drawing.Size(327, 22);
            this.tBoxEditora.TabIndex = 27;
            // 
            // tBoxAutor
            // 
            this.tBoxAutor.Location = new System.Drawing.Point(235, 122);
            this.tBoxAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxAutor.Name = "tBoxAutor";
            this.tBoxAutor.Size = new System.Drawing.Size(651, 22);
            this.tBoxAutor.TabIndex = 26;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(235, 69);
            this.tBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(651, 22);
            this.tBoxNome.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Editora do Livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Autor do Livro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nome do Livro:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(793, 371);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 39);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(694, 371);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 39);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbCodigoLivro
            // 
            this.tbCodigoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoLivro.Location = new System.Drawing.Point(457, 20);
            this.tbCodigoLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoLivro.Name = "tbCodigoLivro";
            this.tbCodigoLivro.Size = new System.Drawing.Size(111, 28);
            this.tbCodigoLivro.TabIndex = 1;
            this.tbCodigoLivro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código do Livro:";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(593, 18);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(85, 33);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPesqTodosLivro);
            this.tabPage2.Controls.Add(this.dataGridViewLivro);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(930, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa Tudo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPesqTodosLivro
            // 
            this.btnPesqTodosLivro.Location = new System.Drawing.Point(381, 17);
            this.btnPesqTodosLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesqTodosLivro.Name = "btnPesqTodosLivro";
            this.btnPesqTodosLivro.Size = new System.Drawing.Size(251, 37);
            this.btnPesqTodosLivro.TabIndex = 1;
            this.btnPesqTodosLivro.Text = "Pesquisar Todos os Livros:";
            this.btnPesqTodosLivro.UseVisualStyleBackColor = true;
            this.btnPesqTodosLivro.Click += new System.EventHandler(this.btnPesqTodosLivro_Click);
            // 
            // dataGridViewLivro
            // 
            this.dataGridViewLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.autor,
            this.editora,
            this.Ano,
            this.genero,
            this.paginas});
            this.dataGridViewLivro.Location = new System.Drawing.Point(5, 68);
            this.dataGridViewLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLivro.Name = "dataGridViewLivro";
            this.dataGridViewLivro.RowHeadersWidth = 51;
            this.dataGridViewLivro.RowTemplate.Height = 24;
            this.dataGridViewLivro.Size = new System.Drawing.Size(983, 393);
            this.dataGridViewLivro.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor:";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.Width = 125;
            // 
            // editora
            // 
            this.editora.HeaderText = "Editora:";
            this.editora.MinimumWidth = 6;
            this.editora.Name = "editora";
            this.editora.Width = 125;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.Width = 125;
            // 
            // genero
            // 
            this.genero.HeaderText = "Gênero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.Width = 125;
            // 
            // paginas
            // 
            this.paginas.HeaderText = "Páginas";
            this.paginas.MinimumWidth = 6;
            this.paginas.Name = "paginas";
            this.paginas.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(466, 52);
            this.label6.TabIndex = 18;
            this.label6.Text = "PESQUISAR LIVROS";
            // 
            // TelaPesquisaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 525);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPesquisaLivro";
            this.Text = "TelaPesquisaLivro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbCodigoLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPesqTodosLivro;
        private System.Windows.Forms.DataGridView dataGridViewLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxPaginas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPickerLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxEditora;
        private System.Windows.Forms.TextBox tBoxAutor;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
    }
}