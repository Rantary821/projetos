CREATE TABLE `clientes` (
  `idCliente` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Rg` varchar(13) NOT NULL,
  `DataNasc` varchar(10) NOT NULL,
  `Rua` varchar(10) NOT NULL,
  `Bairro` varchar(50) NOT NULL,
  `Numero` varchar(10) NOT NULL,
  `Divida` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `diastrabalhados` (
  `IdFuncionario` int(10) NOT NULL,
  `DiasTrabalhados` varchar(80) NOT NULL,
  `NumDias` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `fornecedor` (
  `idFornecedor` int(11) NOT NULL,
  `idProduto` int(11) NOT NULL,
  `telefone` varchar(11) DEFAULT NULL,
  `cnpjcpf` varchar(12) DEFAULT NULL,
  `endereço` varchar(80) DEFAULT NULL,
  `cidade` varchar(80) DEFAULT NULL,
  `estado` varchar(80) DEFAULT NULL,
  `nome` varchar(120) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `funcionario` (
  `Nome` varchar(100) NOT NULL,
  `IdFuncionario` int(10) NOT NULL,
  `Rg` varchar(13) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `ValorDiaria` varchar(10) NOT NULL,
  `SalarioFinal` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `login` (
  `Usuario` varchar(50) NOT NULL,
  `Senha` varchar(16) NOT NULL,
  `IdUser` int(10) NOT NULL,
  `CadFuncio` varchar(3) NOT NULL,
  `DelFuncio` varchar(3) NOT NULL,
  `GoFichas` varchar(3) NOT NULL,
  `GoEstoq` varchar(3) NOT NULL,
  `EnterProdutos` varchar(3) NOT NULL,
  `CadClientes` varchar(3) NOT NULL,
  `UpClientes` varchar(3) NOT NULL,
  `DelClientes` varchar(3) NOT NULL,
  `Vender` varchar(3) NOT NULL,
  `CheckCadFornece` varchar(3) NOT NULL,
  `Pagamentos` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `produtos` (
  `idProduto` int(11) NOT NULL,
  `idFornecedor` int(11) NOT NULL,
  `quantidadeEstoque` int(11) NOT NULL,
  `quantMax` int(11) NOT NULL,
  `quantMin` int(11) NOT NULL,
  `nomeProduto` varchar(80) NOT NULL,
  `preco` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `salarios` (
  `salario` varchar(11) NOT NULL,
  `mes` varchar(20) NOT NULL,
  `IdFuncionario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `vendas` (
  `idCliente` int(10) NOT NULL,
  `Produto` varchar(11) NOT NULL,
  `idVenda` int(11) NOT NULL,
  `PrecoUni` varchar(10) NOT NULL,
  `quant` int(10) NOT NULL,
  `Detalhes` varchar(80) NOT NULL,
  `ValorTotal` varchar(10) NOT NULL,
  `DataCompra` varchar(20) NOT NULL,
  `Forma` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idCliente`);
  
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`idFornecedor`);
  
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`IdFuncionario`);
  
ALTER TABLE `login`
  ADD PRIMARY KEY (`IdUser`);
  
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`idProduto`);
  
ALTER TABLE `clientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
  
ALTER TABLE `login`
  MODIFY `IdUser` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
  
ALTER TABLE `produtos`
  MODIFY `idProduto` int(11) NOT NULL AUTO_INCREMENT;