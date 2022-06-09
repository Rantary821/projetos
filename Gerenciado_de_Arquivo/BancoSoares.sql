 Database: `soares`

CREATE TABLE `aluno` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `rg` varchar(14) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `ra` varchar(14) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  `dataNasc` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `dados` (
  `id` int(11) NOT NULL,
  `tel` varchar(14) DEFAULT NULL,
  `cel` varchar(15) DEFAULT NULL,
  `email` varchar(80) DEFAULT NULL,
  `idAluno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `aluno`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `dados`
  ADD PRIMARY KEY (`id`);
EMENT for table `dados`

ALTER TABLE `dados`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
