CREATE TABLE [dbo].[Empresas]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [NomeFantasia] TEXT NOT NULL, 
    [Cnpj] VARCHAR(50) NOT NULL, 
    [DataHoraRegistroEmpresa] DATETIME NOT NULL
)
