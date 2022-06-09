DROP TABLE dbo.aluno;
DROP TABLE dbo.contato;
DROP TABLE dbo.curso;
DROP TABLE dbo.endereco;
DROP TABLE dbo.matricula;


CREATE TABLE aluno (
  idAluno int IDENTITY(1,1) primary key NOT NULL,
  nome varchar(100) NOT NULL,
  rg varchar(13) DEFAULT NULL,
  cpf varchar(14) NOT NULL
) ;

CREATE TABLE contato (
  Cel1 varchar(14) DEFAULT NULL,
  Cel2 varchar(13) DEFAULT NULL,
  Tel1 varchar(13) DEFAULT NULL,
  Tel2 varchar(13) DEFAULT NULL,
  IdContato int IDENTITY(1,1) primary key NOT NULL,
  IdAluno int NOT NULL,
  Email1 varchar(80) DEFAULT NULL,
  Email2 varchar(80) DEFAULT NULL
);

CREATE TABLE curso (
  IdCurso int primary key NOT NULL,
  NomeCurso varchar(80) NOT NULL
) ;

CREATE TABLE endereco (
  rua varchar(30) NOT NULL,
  bairro varchar(30) NOT NULL,
  numero varchar(30) NOT NULL,
  complemento varchar(30) DEFAULT NULL,
  idEndereco int IDENTITY(1,1) primary key NOT NULL,
  IdAluno int NOT NULL,
  Cidade varchar(80) NOT NULL,
  Uf varchar(2) NOT NULL,
  Cep varchar(11) NOT NULL
) ;

CREATE TABLE matricula (
  idPrimario int IDENTITY(1,1) primary key NOT NULL,
  idMatricula int  NOT NULL,
  idAluno int NOT NULL,
  idCurso int NOT NULL,
  AnoMat int NOT NULL,
  Concluinte varchar(3) NOT NULL,
  Deletado varchar(3) 
) ;	




INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Sistemas'
);

INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Nutrição'
);

INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Cozinha'
);

INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Quimica'
);

INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Mecanica'
);

INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Administração'
);

INSERT INTO dbo.curso
(
    NomeCurso
)
VALUES
('Segunraça do trabalho'


);