CREATE TABLE [dbo].[Fornecedores]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TipoDePessoa] CHAR(10) NOT NULL, 
    [Empresa] VARCHAR(80) NOT NULL, 
    [Nome] VARCHAR(80) NOT NULL, 
    [CpfCnpj] VARCHAR(50) NOT NULL, 
    [DataDeNascimento] DATE NOT NULL, 
    [Telefone] VARCHAR(50) NOT NULL, 
    [DataHoraRegistroFornecedor] DATETIME NOT NULL
)
