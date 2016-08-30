

IF OBJECT_ID('dbo.usuarios','U') IS NOT NULL DROP TABLE dbo.usuarios

CREATE TABLE usuarios(
codigo INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
login VARCHAR(100),
senha VARCHAR(100),
dt_atualizacao SMALLDATETIME DEFAULT GETDATE()
);

INSERT INTO usuarios(nome,login,senha) VALUES('Administrador','admin','admin');