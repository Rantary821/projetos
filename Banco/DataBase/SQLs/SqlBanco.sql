CREATE TABLE [dbo].[aluno] (
    [idAluno] INT           IDENTITY (1, 1) NOT NULL,
    [nome]    VARCHAR (100) NOT NULL,
    [rg]      VARCHAR (13)  DEFAULT (NULL) NULL,
    [cpf]     VARCHAR (14)  NOT NULL,
    PRIMARY KEY CLUSTERED ([idAluno] ASC)
);

CREATE TABLE [dbo].[config] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [tema]            VARCHAR (20) NOT NULL,
    [mostrarContatos] VARCHAR (3)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[contato] (
    [Cel1]      VARCHAR (14) DEFAULT (NULL) NULL,
    [Cel2]      VARCHAR (13) DEFAULT (NULL) NULL,
    [Tel1]      VARCHAR (13) DEFAULT (NULL) NULL,
    [Tel2]      VARCHAR (13) DEFAULT (NULL) NULL,
    [IdContato] INT          IDENTITY (1, 1) NOT NULL,
    [IdAluno]   INT          NOT NULL,
    [Email1]    VARCHAR (80) DEFAULT (NULL) NULL,
    [Email2]    VARCHAR (80) DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([IdContato] ASC)
);

CREATE TABLE [dbo].[curso] (
    [IdCurso]   INT          NOT NULL,
    [NomeCurso] VARCHAR (80) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCurso] ASC)
);

CREATE TABLE [dbo].[datas] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (80)  NULL,
    [Datas] VARCHAR (120) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[endereco] (
    [rua]         VARCHAR (30) NOT NULL,
    [bairro]      VARCHAR (30) NOT NULL,
    [numero]      VARCHAR (30) NOT NULL,
    [complemento] VARCHAR (30) DEFAULT (NULL) NULL,
    [idEndereco]  INT          IDENTITY (1, 1) NOT NULL,
    [IdAluno]     INT          NOT NULL,
    [Cidade]      VARCHAR (80) NOT NULL,
    [Uf]          VARCHAR (2)  NOT NULL,
    [Cep]         VARCHAR (11) NOT NULL,
    PRIMARY KEY CLUSTERED ([idEndereco] ASC)
);

CREATE TABLE [dbo].[matricula] (
    [idPrimario]  INT         IDENTITY (1, 1) NOT NULL,
    [idMatricula] INT         NOT NULL,
    [idAluno]     INT         NOT NULL,
    [idCurso]     INT         NOT NULL,
    [AnoMat]      INT         NOT NULL,
    [Concluinte]  VARCHAR (3) NOT NULL,
    [Deletado]    VARCHAR (3) NULL,
    PRIMARY KEY CLUSTERED ([idPrimario] ASC)
);