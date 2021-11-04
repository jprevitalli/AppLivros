
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbCodigoFun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPesqTodosFun = new System.Windows.Forms.Button();
            this.dataGridViewfuncionario = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 404);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
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
            this.tabPage1.Controls.Add(this.tbCodigoFun);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBusca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(745, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(647, 331);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 32);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(573, 331);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(70, 32);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // tbCodigoFun
            // 
            this.tbCodigoFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFun.Location = new System.Drawing.Point(343, 16);
            this.tbCodigoFun.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoFun.Name = "tbCodigoFun";
            this.tbCodigoFun.Size = new System.Drawing.Size(84, 24);
            this.tbCodigoFun.TabIndex = 1;
            this.tbCodigoFun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código do Livro:";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(445, 15);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(64, 27);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPesqTodosFun);
            this.tabPage2.Controls.Add(this.dataGridViewfuncionario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(745, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa Tudo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPesqTodosFun
            // 
            this.btnPesqTodosFun.Location = new System.Drawing.Point(286, 14);
            this.btnPesqTodosFun.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqTodosFun.Name = "btnPesqTodosFun";
            this.btnPesqTodosFun.Size = new System.Drawing.Size(188, 30);
            this.btnPesqTodosFun.TabIndex = 1;
            this.btnPesqTodosFun.Text = "Pesquisar Todos os Livros:";
            this.btnPesqTodosFun.UseVisualStyleBackColor = true;
            // 
            // dataGridViewfuncionario
            // 
            this.dataGridViewfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.autor,
            this.editora,
            this.Ano,
            this.genero,
            this.paginas});
            this.dataGridViewfuncionario.Location = new System.Drawing.Point(4, 55);
            this.dataGridViewfuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewfuncionario.Name = "dataGridViewfuncionario";
            this.dataGridViewfuncionario.RowHeadersWidth = 51;
            this.dataGridViewfuncionario.RowTemplate.Height = 24;
            this.dataGridViewfuncionario.Size = new System.Drawing.Size(737, 319);
            this.dataGridViewfuncionario.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meteora DEMO", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(420, 43);
            this.label6.TabIndex = 18;
            this.label6.Text = "PESQUISAR LIVROS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 343);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Páginas do Livro:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
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
            this.listBox1.Location = new System.Drawing.Point(178, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 95);
            this.listBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ano do Livro:";
            // 
            // dTPickerLivro
            // 
            this.dTPickerLivro.CustomFormat = "";
            this.dTPickerLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerLivro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerLivro.Location = new System.Drawing.Point(178, 182);
            this.dTPickerLivro.Name = "dTPickerLivro";
            this.dTPickerLivro.Size = new System.Drawing.Size(129, 24);
            this.dTPickerLivro.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ano do Livro:";
            // 
            // tBoxEditora
            // 
            this.tBoxEditora.Location = new System.Drawing.Point(176, 142);
            this.tBoxEditora.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxEditora.Name = "tBoxEditora";
            this.tBoxEditora.Size = new System.Drawing.Size(246, 20);
            this.tBoxEditora.TabIndex = 27;
            // 
            // tBoxAutor
            // 
            this.tBoxAutor.Location = new System.Drawing.Point(176, 99);
            this.tBoxAutor.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxAutor.Name = "tBoxAutor";
            this.tBoxAutor.Size = new System.Drawing.Size(489, 20);
            this.tBoxAutor.TabIndex = 26;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(176, 56);
            this.tBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(489, 20);
            this.tBoxNome.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Editora do Livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Autor do Livro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nome do Livro:";
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
            this.Ano.Name = "Ano";
            // 
            // genero
            // 
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            // 
            // paginas
            // 
            this.paginas.HeaderText = "Páginas";
            this.paginas.Name = "paginas";
            // 
            // TelaPesquisaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 469);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPesquisaLivro";
            this.Text = "TelaPesquisaLivro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbCodigoFun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPesqTodosFun;
        private System.Windows.Forms.DataGridView dataGridViewfuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
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