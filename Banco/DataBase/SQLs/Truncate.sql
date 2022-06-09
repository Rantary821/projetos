select * from matricula;
select * from aluno;
select * from contato;
select * from endereco;
select * from curso;

select top 10 m.idPrimario, m.idMatricula, a.nome, c.NomeCurso, m.Concluinte from aluno a 
JOIN dbo.matricula m ON m.idAluno = a.idAluno JOIN dbo.curso c ON c.IdCurso = m.idCurso WHERE m.Deletado = 'NAO' ORDER by m.idPrimario DESC;


truncate table aluno;
truncate table contato;
truncate table curso;
truncate table endereco;
truncate table config;
truncate table datas;
truncate table matricula;
insert into config (tema, mostrarContatos)values ('', '');


INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('1', 'Sistemas'
);

INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('2','Nutrição'
);

INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('3','Cozinha'
);

INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('4','Quimica'
);

INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('5','Mecanica'
);

INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('6','Administração'
);

INSERT INTO dbo.curso
(
    IdCurso, NomeCurso
)
VALUES
('7','Segunraça do trabalho'
);