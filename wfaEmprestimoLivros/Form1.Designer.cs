namespace wfaEmprestimoLivros
{
    partial class Form1
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
            this.tabAbas = new System.Windows.Forms.TabControl();
            this.tabAlunos = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dGValuno = new System.Windows.Forms.DataGridView();
            this.bSairAluno = new System.Windows.Forms.Button();
            this.bExcluirAluno = new System.Windows.Forms.Button();
            this.bRelatórioAluno = new System.Windows.Forms.Button();
            this.bAtualizarAluno = new System.Windows.Forms.Button();
            this.bGravarAluno = new System.Windows.Forms.Button();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabLivro = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dGVlivro = new System.Windows.Forms.DataGridView();
            this.mtbCadastro = new System.Windows.Forms.MaskedTextBox();
            this.bSairLivro = new System.Windows.Forms.Button();
            this.bExcluirLivro = new System.Windows.Forms.Button();
            this.bRelatorioLivro = new System.Windows.Forms.Button();
            this.bAtualizarLivro = new System.Windows.Forms.Button();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbEdicao = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblEdicao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.bGravarLivro = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dGVemprestimo = new System.Windows.Forms.DataGridView();
            this.bSairEmprestimo = new System.Windows.Forms.Button();
            this.bExcluirEmprestimo = new System.Windows.Forms.Button();
            this.bRelatorioEmprestimo = new System.Windows.Forms.Button();
            this.bAtualizarEmprestimo = new System.Windows.Forms.Button();
            this.bGravarEmprestimo = new System.Windows.Forms.Button();
            this.tbMatriculaAluno = new System.Windows.Forms.TextBox();
            this.tbCadastroLivro = new System.Windows.Forms.TextBox();
            this.lblMatriculaAluno = new System.Windows.Forms.Label();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.tabAbas.SuspendLayout();
            this.tabAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGValuno)).BeginInit();
            this.tabLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVlivro)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVemprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAbas
            // 
            this.tabAbas.Controls.Add(this.tabAlunos);
            this.tabAbas.Controls.Add(this.tabLivro);
            this.tabAbas.Controls.Add(this.tabPage1);
            this.tabAbas.Location = new System.Drawing.Point(12, 12);
            this.tabAbas.Name = "tabAbas";
            this.tabAbas.SelectedIndex = 0;
            this.tabAbas.Size = new System.Drawing.Size(776, 426);
            this.tabAbas.TabIndex = 6;
            // 
            // tabAlunos
            // 
            this.tabAlunos.Controls.Add(this.label4);
            this.tabAlunos.Controls.Add(this.dGValuno);
            this.tabAlunos.Controls.Add(this.bSairAluno);
            this.tabAlunos.Controls.Add(this.bExcluirAluno);
            this.tabAlunos.Controls.Add(this.bRelatórioAluno);
            this.tabAlunos.Controls.Add(this.bAtualizarAluno);
            this.tabAlunos.Controls.Add(this.bGravarAluno);
            this.tabAlunos.Controls.Add(this.mtbCpf);
            this.tabAlunos.Controls.Add(this.tbNome);
            this.tabAlunos.Controls.Add(this.tbMatricula);
            this.tabAlunos.Controls.Add(this.label1);
            this.tabAlunos.Controls.Add(this.label2);
            this.tabAlunos.Controls.Add(this.label3);
            this.tabAlunos.Location = new System.Drawing.Point(4, 25);
            this.tabAlunos.Name = "tabAlunos";
            this.tabAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlunos.Size = new System.Drawing.Size(768, 397);
            this.tabAlunos.TabIndex = 0;
            this.tabAlunos.Text = "Aluno";
            this.tabAlunos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "obs: Para manipular (atualizar/deletar) um aluno, inserir o CPF:";
            // 
            // dGValuno
            // 
            this.dGValuno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGValuno.Location = new System.Drawing.Point(42, 223);
            this.dGValuno.Name = "dGValuno";
            this.dGValuno.RowHeadersWidth = 51;
            this.dGValuno.RowTemplate.Height = 24;
            this.dGValuno.Size = new System.Drawing.Size(686, 155);
            this.dGValuno.TabIndex = 19;
            // 
            // bSairAluno
            // 
            this.bSairAluno.Location = new System.Drawing.Point(607, 194);
            this.bSairAluno.Name = "bSairAluno";
            this.bSairAluno.Size = new System.Drawing.Size(75, 23);
            this.bSairAluno.TabIndex = 17;
            this.bSairAluno.Text = "Sair";
            this.bSairAluno.UseVisualStyleBackColor = true;
            this.bSairAluno.Click += new System.EventHandler(this.bSairAluno_Click);
            // 
            // bExcluirAluno
            // 
            this.bExcluirAluno.Location = new System.Drawing.Point(481, 194);
            this.bExcluirAluno.Name = "bExcluirAluno";
            this.bExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.bExcluirAluno.TabIndex = 16;
            this.bExcluirAluno.Text = "Excluir";
            this.bExcluirAluno.UseVisualStyleBackColor = true;
            this.bExcluirAluno.Click += new System.EventHandler(this.bExcluirAluno_Click);
            // 
            // bRelatórioAluno
            // 
            this.bRelatórioAluno.Location = new System.Drawing.Point(355, 194);
            this.bRelatórioAluno.Name = "bRelatórioAluno";
            this.bRelatórioAluno.Size = new System.Drawing.Size(85, 23);
            this.bRelatórioAluno.TabIndex = 15;
            this.bRelatórioAluno.Text = "Relatório";
            this.bRelatórioAluno.UseVisualStyleBackColor = true;
            this.bRelatórioAluno.Click += new System.EventHandler(this.bRelatórioAluno_Click);
            // 
            // bAtualizarAluno
            // 
            this.bAtualizarAluno.Location = new System.Drawing.Point(229, 194);
            this.bAtualizarAluno.Name = "bAtualizarAluno";
            this.bAtualizarAluno.Size = new System.Drawing.Size(75, 23);
            this.bAtualizarAluno.TabIndex = 14;
            this.bAtualizarAluno.Text = "Atualizar";
            this.bAtualizarAluno.UseVisualStyleBackColor = true;
            this.bAtualizarAluno.Click += new System.EventHandler(this.bAtualizarAluno_Click);
            // 
            // bGravarAluno
            // 
            this.bGravarAluno.Location = new System.Drawing.Point(103, 194);
            this.bGravarAluno.Name = "bGravarAluno";
            this.bGravarAluno.Size = new System.Drawing.Size(75, 23);
            this.bGravarAluno.TabIndex = 13;
            this.bGravarAluno.Text = "Gravar";
            this.bGravarAluno.UseVisualStyleBackColor = true;
            this.bGravarAluno.Click += new System.EventHandler(this.bGravarAluno_Click);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(118, 104);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(120, 22);
            this.mtbCpf.TabIndex = 11;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(118, 36);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(312, 22);
            this.tbNome.TabIndex = 10;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(118, 70);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(312, 22);
            this.tbMatricula.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // tabLivro
            // 
            this.tabLivro.Controls.Add(this.label5);
            this.tabLivro.Controls.Add(this.dGVlivro);
            this.tabLivro.Controls.Add(this.mtbCadastro);
            this.tabLivro.Controls.Add(this.bSairLivro);
            this.tabLivro.Controls.Add(this.bExcluirLivro);
            this.tabLivro.Controls.Add(this.bRelatorioLivro);
            this.tabLivro.Controls.Add(this.bAtualizarLivro);
            this.tabLivro.Controls.Add(this.tbAno);
            this.tabLivro.Controls.Add(this.tbEdicao);
            this.tabLivro.Controls.Add(this.tbAutor);
            this.tabLivro.Controls.Add(this.tbTitulo);
            this.tabLivro.Controls.Add(this.lblAutor);
            this.tabLivro.Controls.Add(this.lblAno);
            this.tabLivro.Controls.Add(this.lblEdicao);
            this.tabLivro.Controls.Add(this.lblTitulo);
            this.tabLivro.Controls.Add(this.lblCadastro);
            this.tabLivro.Controls.Add(this.bGravarLivro);
            this.tabLivro.Location = new System.Drawing.Point(4, 25);
            this.tabLivro.Name = "tabLivro";
            this.tabLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivro.Size = new System.Drawing.Size(768, 397);
            this.tabLivro.TabIndex = 1;
            this.tabLivro.Text = "Livro";
            this.tabLivro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "obs: Para manipular (atualizar/deletar) um Livro, inserir o Cadastro do Livro";
            // 
            // dGVlivro
            // 
            this.dGVlivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVlivro.Location = new System.Drawing.Point(6, 257);
            this.dGVlivro.Name = "dGVlivro";
            this.dGVlivro.RowHeadersWidth = 51;
            this.dGVlivro.RowTemplate.Height = 24;
            this.dGVlivro.Size = new System.Drawing.Size(756, 137);
            this.dGVlivro.TabIndex = 10;
            // 
            // mtbCadastro
            // 
            this.mtbCadastro.Location = new System.Drawing.Point(129, 32);
            this.mtbCadastro.Name = "mtbCadastro";
            this.mtbCadastro.Size = new System.Drawing.Size(72, 22);
            this.mtbCadastro.TabIndex = 9;
            // 
            // bSairLivro
            // 
            this.bSairLivro.Location = new System.Drawing.Point(593, 228);
            this.bSairLivro.Name = "bSairLivro";
            this.bSairLivro.Size = new System.Drawing.Size(75, 23);
            this.bSairLivro.TabIndex = 8;
            this.bSairLivro.Text = "Sair";
            this.bSairLivro.UseVisualStyleBackColor = true;
            this.bSairLivro.Click += new System.EventHandler(this.bSairLivro_Click);
            // 
            // bExcluirLivro
            // 
            this.bExcluirLivro.Location = new System.Drawing.Point(467, 228);
            this.bExcluirLivro.Name = "bExcluirLivro";
            this.bExcluirLivro.Size = new System.Drawing.Size(75, 23);
            this.bExcluirLivro.TabIndex = 8;
            this.bExcluirLivro.Text = "Excluir";
            this.bExcluirLivro.UseVisualStyleBackColor = true;
            this.bExcluirLivro.Click += new System.EventHandler(this.bExcluirLivro_Click);
            // 
            // bRelatorioLivro
            // 
            this.bRelatorioLivro.Location = new System.Drawing.Point(341, 228);
            this.bRelatorioLivro.Name = "bRelatorioLivro";
            this.bRelatorioLivro.Size = new System.Drawing.Size(84, 23);
            this.bRelatorioLivro.TabIndex = 8;
            this.bRelatorioLivro.Text = "Relatório";
            this.bRelatorioLivro.UseVisualStyleBackColor = true;
            this.bRelatorioLivro.Click += new System.EventHandler(this.bRelatorioLivro_Click);
            // 
            // bAtualizarLivro
            // 
            this.bAtualizarLivro.Location = new System.Drawing.Point(215, 228);
            this.bAtualizarLivro.Name = "bAtualizarLivro";
            this.bAtualizarLivro.Size = new System.Drawing.Size(75, 23);
            this.bAtualizarLivro.TabIndex = 8;
            this.bAtualizarLivro.Text = "Atualizar";
            this.bAtualizarLivro.UseVisualStyleBackColor = true;
            this.bAtualizarLivro.Click += new System.EventHandler(this.bAtualizarLivro_Click);
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(129, 172);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 6;
            // 
            // tbEdicao
            // 
            this.tbEdicao.Location = new System.Drawing.Point(129, 137);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.Size = new System.Drawing.Size(100, 22);
            this.tbEdicao.TabIndex = 6;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(129, 102);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(287, 22);
            this.tbAutor.TabIndex = 6;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(129, 67);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(287, 22);
            this.tbTitulo.TabIndex = 6;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(83, 105);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(38, 16);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(92, 175);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(31, 16);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Location = new System.Drawing.Point(73, 140);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(50, 16);
            this.lblEdicao.TabIndex = 3;
            this.lblEdicao.Text = "Edição";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(83, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(49, 35);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(79, 16);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "N° Cadastro";
            // 
            // bGravarLivro
            // 
            this.bGravarLivro.Location = new System.Drawing.Point(89, 228);
            this.bGravarLivro.Name = "bGravarLivro";
            this.bGravarLivro.Size = new System.Drawing.Size(75, 23);
            this.bGravarLivro.TabIndex = 0;
            this.bGravarLivro.Text = "Gravar";
            this.bGravarLivro.UseVisualStyleBackColor = true;
            this.bGravarLivro.Click += new System.EventHandler(this.bGravarLivro_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dGVemprestimo);
            this.tabPage1.Controls.Add(this.bSairEmprestimo);
            this.tabPage1.Controls.Add(this.bExcluirEmprestimo);
            this.tabPage1.Controls.Add(this.bRelatorioEmprestimo);
            this.tabPage1.Controls.Add(this.bAtualizarEmprestimo);
            this.tabPage1.Controls.Add(this.bGravarEmprestimo);
            this.tabPage1.Controls.Add(this.tbMatriculaAluno);
            this.tabPage1.Controls.Add(this.tbCadastroLivro);
            this.tabPage1.Controls.Add(this.lblMatriculaAluno);
            this.tabPage1.Controls.Add(this.lblCadastroLivro);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Empréstimo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(496, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "obs: Para manipular (atualizar/deletar) um Emprestimo, inserir a Matricula do Alu" +
    "no";
            // 
            // dGVemprestimo
            // 
            this.dGVemprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVemprestimo.Location = new System.Drawing.Point(16, 189);
            this.dGVemprestimo.Name = "dGVemprestimo";
            this.dGVemprestimo.RowHeadersWidth = 51;
            this.dGVemprestimo.RowTemplate.Height = 24;
            this.dGVemprestimo.Size = new System.Drawing.Size(730, 192);
            this.dGVemprestimo.TabIndex = 9;
            // 
            // bSairEmprestimo
            // 
            this.bSairEmprestimo.Location = new System.Drawing.Point(580, 148);
            this.bSairEmprestimo.Name = "bSairEmprestimo";
            this.bSairEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.bSairEmprestimo.TabIndex = 0;
            this.bSairEmprestimo.Text = "Sair";
            this.bSairEmprestimo.UseVisualStyleBackColor = true;
            this.bSairEmprestimo.Click += new System.EventHandler(this.bSairEmprestimo_Click);
            // 
            // bExcluirEmprestimo
            // 
            this.bExcluirEmprestimo.Location = new System.Drawing.Point(461, 148);
            this.bExcluirEmprestimo.Name = "bExcluirEmprestimo";
            this.bExcluirEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.bExcluirEmprestimo.TabIndex = 8;
            this.bExcluirEmprestimo.Text = "Excluir";
            this.bExcluirEmprestimo.UseVisualStyleBackColor = true;
            this.bExcluirEmprestimo.Click += new System.EventHandler(this.bExcluirEmprestimo_Click);
            // 
            // bRelatorioEmprestimo
            // 
            this.bRelatorioEmprestimo.Location = new System.Drawing.Point(342, 148);
            this.bRelatorioEmprestimo.Name = "bRelatorioEmprestimo";
            this.bRelatorioEmprestimo.Size = new System.Drawing.Size(87, 23);
            this.bRelatorioEmprestimo.TabIndex = 7;
            this.bRelatorioEmprestimo.Text = "Relatório";
            this.bRelatorioEmprestimo.UseVisualStyleBackColor = true;
            this.bRelatorioEmprestimo.Click += new System.EventHandler(this.bRelatorioEmprestimo_Click);
            // 
            // bAtualizarEmprestimo
            // 
            this.bAtualizarEmprestimo.Location = new System.Drawing.Point(223, 148);
            this.bAtualizarEmprestimo.Name = "bAtualizarEmprestimo";
            this.bAtualizarEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.bAtualizarEmprestimo.TabIndex = 6;
            this.bAtualizarEmprestimo.Text = "Atualizar";
            this.bAtualizarEmprestimo.UseVisualStyleBackColor = true;
            this.bAtualizarEmprestimo.Click += new System.EventHandler(this.bAtualizarEmprestimo_Click);
            // 
            // bGravarEmprestimo
            // 
            this.bGravarEmprestimo.Location = new System.Drawing.Point(106, 148);
            this.bGravarEmprestimo.Name = "bGravarEmprestimo";
            this.bGravarEmprestimo.Size = new System.Drawing.Size(73, 23);
            this.bGravarEmprestimo.TabIndex = 5;
            this.bGravarEmprestimo.Text = "Gravar";
            this.bGravarEmprestimo.UseVisualStyleBackColor = true;
            this.bGravarEmprestimo.Click += new System.EventHandler(this.bGravarEmprestimo_Click);
            // 
            // tbMatriculaAluno
            // 
            this.tbMatriculaAluno.Location = new System.Drawing.Point(203, 99);
            this.tbMatriculaAluno.Name = "tbMatriculaAluno";
            this.tbMatriculaAluno.Size = new System.Drawing.Size(140, 22);
            this.tbMatriculaAluno.TabIndex = 3;
            // 
            // tbCadastroLivro
            // 
            this.tbCadastroLivro.Location = new System.Drawing.Point(203, 57);
            this.tbCadastroLivro.Name = "tbCadastroLivro";
            this.tbCadastroLivro.Size = new System.Drawing.Size(140, 22);
            this.tbCadastroLivro.TabIndex = 2;
            // 
            // lblMatriculaAluno
            // 
            this.lblMatriculaAluno.AutoSize = true;
            this.lblMatriculaAluno.Location = new System.Drawing.Point(79, 99);
            this.lblMatriculaAluno.Name = "lblMatriculaAluno";
            this.lblMatriculaAluno.Size = new System.Drawing.Size(117, 16);
            this.lblMatriculaAluno.TabIndex = 1;
            this.lblMatriculaAluno.Text = "Matrícula do Aluno";
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Location = new System.Drawing.Point(65, 60);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(131, 16);
            this.lblCadastroLivro.TabIndex = 0;
            this.lblCadastroLivro.Text = "Nº Cadastro do Livro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabAbas);
            this.Name = "Form1";
            this.Text = "Emprestimo Livros";
            this.tabAbas.ResumeLayout(false);
            this.tabAlunos.ResumeLayout(false);
            this.tabAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGValuno)).EndInit();
            this.tabLivro.ResumeLayout(false);
            this.tabLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVlivro)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVemprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabAbas;
        private System.Windows.Forms.TabPage tabAlunos;
        private System.Windows.Forms.TabPage tabLivro;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bGravarAluno;
        private System.Windows.Forms.Label lblEdicao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button bGravarLivro;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbEdicao;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.TextBox tbMatriculaAluno;
        private System.Windows.Forms.TextBox tbCadastroLivro;
        private System.Windows.Forms.Label lblMatriculaAluno;
        private System.Windows.Forms.Button bSairAluno;
        private System.Windows.Forms.Button bExcluirAluno;
        private System.Windows.Forms.Button bRelatórioAluno;
        private System.Windows.Forms.Button bAtualizarAluno;
        private System.Windows.Forms.Button bSairLivro;
        private System.Windows.Forms.Button bExcluirLivro;
        private System.Windows.Forms.Button bRelatorioLivro;
        private System.Windows.Forms.Button bAtualizarLivro;
        private System.Windows.Forms.Button bSairEmprestimo;
        private System.Windows.Forms.Button bExcluirEmprestimo;
        private System.Windows.Forms.Button bRelatorioEmprestimo;
        private System.Windows.Forms.Button bAtualizarEmprestimo;
        private System.Windows.Forms.Button bGravarEmprestimo;
        private System.Windows.Forms.MaskedTextBox mtbCadastro;
        private System.Windows.Forms.DataGridView dGValuno;
        private System.Windows.Forms.DataGridView dGVlivro;
        private System.Windows.Forms.DataGridView dGVemprestimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

