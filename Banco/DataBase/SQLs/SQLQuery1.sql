select a.nome, a.cpf, c.NomeCurso, m.idPrimario, m.idMatricula as 'pasta' from aluno a join matricula m on m.idAluno = a.idAluno join curso c on c.IdCurso = m.idCurso where m.Deletado = 'NAO' AND m.Deletado AND a.cpf = '44679016809';

select * from matricula;