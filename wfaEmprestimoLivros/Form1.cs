using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEmprestimoLivros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tbNome.Text = string.Empty;
            tbMatricula.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            
            mtbCadastro.Text = string.Empty;
            tbTitulo.Text = string.Empty;
            tbAutor.Text = string.Empty;
            tbEdicao.Text = string.Empty;
            tbAno.Text = string.Empty;

            tbMatriculaAluno.Text = string.Empty;
            tbCadastroLivro.Text = string.Empty;
        }

        private void bGravarAluno_Click(object sender, EventArgs e)
        {
            try 
            {
                Aluno objaluno = new Aluno(tbNome.Text, tbMatricula.Text, mtbCpf.Text);

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection connect = new NpgsqlConnection(conexao);

                connect.Open();

                string comando = String.Format("INSERT INTO aluno(nome_aluno, matricula_aluno, cpf_aluno)" +
                    "values('{0}','{1}','{2}')", objaluno.Name, objaluno.Matricula, objaluno.Cpf);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                connect.Close();
                MessageBox.Show("Aluno cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Verifique se já não existe um Aluno com este CPF ou Matrícula!", 
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void bAtualizarAluno_Click(object sender, EventArgs e)
        {
            string cpf = mtbCpf.Text;

            Aluno objaluno = new Aluno(tbNome.Text, tbMatricula.Text, mtbCpf.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            string comando = String.Format("UPDATE aluno SET nome_aluno = '" + objaluno.Name + "', matricula_aluno = '" 
                + objaluno.Matricula + "', cpf_aluno = '" + objaluno.Cpf + "'  Where cpf_aluno = '" + cpf + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Aluno atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void bRelatórioAluno_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            DataTable dt = new DataTable();

            string comando = String.Format("SELECT * FROM aluno ORDER BY nome_aluno");

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(comando, conexao))
            {
                Adpt.Fill(dt);
            }

            dGValuno.DataSource = dt;

            connect.Close();
        }

        private void bExcluirAluno_Click(object sender, EventArgs e)
        {
            string cpf = mtbCpf.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            string comando = String.Format("DELETE FROM aluno WHERE cpf_aluno = '" + cpf + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Aluno excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void bGravarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                Livro objlivro = new Livro(mtbCadastro.Text, tbTitulo.Text, tbAutor.Text, tbEdicao.Text,
                tbAno.Text);

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection connect = new NpgsqlConnection(conexao);

                connect.Open();

                string comando = String.Format("INSERT INTO livro(cadastro_livro, titulo_livro, autor_livro, edicao_livro, ano_livro)" +
                    "values('{0}','{1}','{2}','{3}','{4}')", objlivro.Cadastro, objlivro.Titulo, objlivro.Autor, objlivro.Edicao, objlivro.Ano);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                connect.Close();
                MessageBox.Show("Livro cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show("Verifique se já não existe um Livro com este cadastro!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void bAtualizarLivro_Click(object sender, EventArgs e)
        {
            string cadastro = mtbCadastro.Text;

            Livro objlivro = new Livro(mtbCadastro.Text, tbTitulo.Text, tbAutor.Text, tbEdicao.Text, 
                tbAno.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            string comando = String.Format("UPDATE livro SET cadastro_livro = '" + objlivro.Cadastro + "', titulo_livro = '"
                + objlivro.Titulo + "', autor_livro = '" + objlivro.Autor + "', edicao_livro = '" + objlivro.Edicao + 
                "', ano_livro = '" + objlivro.Ano + "'  WHERE cadastro_livro = '" + cadastro + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Livro atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void bRelatorioLivro_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            DataTable dt = new DataTable();

            string comando = String.Format("SELECT * FROM livro ORDER BY titulo_livro");

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(comando, conexao))
            {
                Adpt.Fill(dt);
            }

            dGVlivro.DataSource = dt;

            connect.Close();
        }
        private void bExcluirLivro_Click(object sender, EventArgs e)
        {
            string cadastro = mtbCadastro.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            string comando = String.Format("DELETE FROM livro WHERE cadastro_livro = '" + cadastro + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Livro excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void bGravarEmprestimo_Click(object sender, EventArgs e)
        {
            string cadastro_livro = tbCadastroLivro.Text;
            string matricula_aluno = tbMatriculaAluno.Text;
            
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            string comando = String.Format("INSERT INTO emprestimo(aluno_matricula, aluno_nome, livro_cadastro, livro_titulo, livro_autor) " +
                "SELECT aluno.matricula_aluno, aluno.nome_aluno, livro.cadastro_livro, livro.titulo_livro, livro.autor_livro" +
                " FROM aluno, livro WHERE matricula_aluno = '" + matricula_aluno + "' AND cadastro_livro = '" + cadastro_livro + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Emprestimo realizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void bAtualizarEmprestimo_Click(object sender, EventArgs e)
        {
            string cadastro_livro = tbCadastroLivro.Text;
            string matricula_aluno = tbMatriculaAluno.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            Aluno objaluno = new Aluno();

            string comando_aluno = String.Format("SELECT * FROM aluno WHERE matricula_aluno = '" + matricula_aluno + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando_aluno, connect))
            {

                NpgsqlDataReader reader = pgsqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    objaluno.Name = reader[0].ToString();
                    objaluno.Matricula = reader[1].ToString();
                    objaluno.Cpf = reader[2].ToString();
                }
                reader.Close();
            }

            Livro objlivro = new Livro();

            string comando_livro = String.Format("SELECT * FROM livro WHERE cadastro_livro = '" + cadastro_livro + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando_livro, connect))
            {

                NpgsqlDataReader reader1 = pgsqlcommand.ExecuteReader();

                while (reader1.Read())
                {
                    objlivro.Cadastro = reader1[0].ToString();
                    objlivro.Titulo = reader1[1].ToString();
                    objlivro.Autor = reader1[2].ToString();
                }
                reader1.Close();
            }

            string comando_emprestimo = String.Format("UPDATE emprestimo SET aluno_matricula = '" + objaluno.Matricula + "', " +
                " aluno_nome = '" + objaluno.Name + "', livro_cadastro = '" + objlivro.Cadastro + "', livro_titulo = '" + objlivro.Titulo + 
                "', livro_autor = '" + objlivro.Autor + "'  WHERE aluno_matricula = '" + matricula_aluno + "' ");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando_emprestimo, connect))
            {
                pgsqlcommand.ExecuteNonQuery();

            }

            connect.Close();
            MessageBox.Show("Emprestimo realizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();

        }

        private void bRelatorioEmprestimo_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            DataTable dt = new DataTable();

            string comando = String.Format("SELECT * FROM emprestimo");

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(comando, conexao))
            {
                Adpt.Fill(dt);
            }

            dGVemprestimo.DataSource = dt;

            connect.Close();
        }

        private void bExcluirEmprestimo_Click(object sender, EventArgs e)
        {
            string cadastro_livro = tbCadastroLivro.Text;
            string matricula_aluno = tbMatriculaAluno.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection connect = new NpgsqlConnection(conexao);

            connect.Open();

            string comando = String.Format("DELETE FROM emprestimo WHERE aluno_matricula = '" + matricula_aluno + "' " +
                "OR livro_cadastro = '" + cadastro_livro + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(comando, connect))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Empréstimo excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();

        }


        private void bSairAluno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSairLivro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSairEmprestimo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
