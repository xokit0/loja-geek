CREATE TABLE [dbo].[perfil]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome] NVARCHAR(50) NOT NULL, 
    [CPF] INT NOT NULL, 
    [funcao] NCHAR(20) NOT NULL
)
