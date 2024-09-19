DROP TABLE aluno;
DROP TABLE livro;
DROP TABLE emprestimo;

CREATE TABLE aluno(
	nome_aluno VARCHAR(100) NOT NULL,
	matricula_aluno VARCHAR(100) NOT NULL UNIQUE,
	cpf_aluno VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE livro(
	cadastro_livro VARCHAR(100) NOT NULL UNIQUE,
	titulo_livro VARCHAR(200) NOT NULL,
	autor_livro VARCHAR(100) NOT NULL,
	edicao_livro VARCHAR(100) NOT NULL,
	ano_livro VARCHAR(100) NOT NULL
);

CREATE TABLE emprestimo(
	aluno_matricula VARCHAR(100) NOT NULL UNIQUE,
	aluno_nome VARCHAR(100) NOT NULL,
	livro_cadastro VARCHAR(200) NOT NULL UNIQUE,
	livro_titulo VARCHAR(100) NOT NULL,
	livro_autor VARCHAR(100) NOT NULL
);

SELECT * FROM aluno;
SELECT * FROM livro;
SELECT * FROM emprestimo;

DELETE FROM emprestimo WHERE aluno_matricula = '12021EMT016';

INSERT INTO aluno(nome_aluno, matricula_aluno, cpf_aluno)
values('Marco Tulio Vilela Fonseca', '12021EMT016', '020,303,916-54');

INSERT INTO livro(cadastro_livro, titulo_livro, autor_livro, edicao_livro, ano_livro)
values('123', 'FDMP', 'Einsten', '4', '2015');

INSERT INTO emprestimo(aluno_matricula, aluno_nome, livro_cadastro, livro_titulo, livro_autor)
SELECT aluno.matricula_aluno, aluno.nome_aluno, livro.cadastro_livro, livro.titulo_livro, livro.autor_livro
FROM aluno, livro 
WHERE matricula_aluno = '12021EMT016' AND cadastro_livro = '253654';

