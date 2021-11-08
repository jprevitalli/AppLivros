
namespace AppLivros
{
    partial class telaCadLivro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxEditora = new System.Windows.Forms.TextBox();
            this.tBoxAutor = new System.Windows.Forms.TextBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPickerLivro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxLivro = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxPaginas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBoxEditora
            // 
            this.tBoxEditora.Location = new System.Drawing.Point(247, 198);
            this.tBoxEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxEditora.Name = "tBoxEditora";
            this.tBoxEditora.Size = new System.Drawing.Size(327, 22);
            this.tBoxEditora.TabIndex = 15;
            // 
            // tBoxAutor
            // 
            this.tBoxAutor.Location = new System.Drawing.Point(247, 145);
            this.tBoxAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxAutor.Name = "tBoxAutor";
            this.tBoxAutor.Size = new System.Drawing.Size(651, 22);
            this.tBoxAutor.TabIndex = 14;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(247, 92);
            this.tBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(651, 22);
            this.tBoxNome.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Editora do Livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Autor do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "CADASTRO DE LIVROS";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(816, 432);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(231, 52);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ano do Livro:";
            // 
            // dTPickerLivro
            // 
            this.dTPickerLivro.CustomFormat = "";
            this.dTPickerLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerLivro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerLivro.Location = new System.Drawing.Point(247, 251);
            this.dTPickerLivro.Margin = new System.Windows.Forms.Padding(4);
            this.dTPickerLivro.Name = "dTPickerLivro";
            this.dTPickerLivro.Size = new System.Drawing.Size(171, 29);
            this.dTPickerLivro.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gênero do Livro:";
            // 
            // listBoxLivro
            // 
            this.listBoxLivro.FormattingEnabled = true;
            this.listBoxLivro.ItemHeight = 16;
            this.listBoxLivro.Items.AddRange(new object[] {
            "Romance",
            "Ficção Literária",
            "Não-Ficção",
            "Ficção Científica",
            "Suspense",
            "Fantasia",
            "Horror",
            "Poesia",
            "Educacional"});
            this.listBoxLivro.Location = new System.Drawing.Point(247, 309);
            this.listBoxLivro.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLivro.Name = "listBoxLivro";
            this.listBoxLivro.Size = new System.Drawing.Size(171, 116);
            this.listBoxLivro.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Páginas do Livro:";
            // 
            // tBoxPaginas
            // 
            this.tBoxPaginas.Location = new System.Drawing.Point(247, 449);
            this.tBoxPaginas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxPaginas.Name = "tBoxPaginas";
            this.tBoxPaginas.Size = new System.Drawing.Size(171, 22);
            this.tBoxPaginas.TabIndex = 21;
            // 
            // telaCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 494);
            this.Controls.Add(this.tBoxPaginas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTPickerLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxEditora);
            this.Controls.Add(this.tBoxAutor);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "telaCadLivro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE LIVRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxEditora;
        private System.Windows.Forms.TextBox tBoxAutor;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPickerLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxLivro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxPaginas;
    }
}

