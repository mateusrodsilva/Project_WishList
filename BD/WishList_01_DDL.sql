CREATE DATABASE Project_WishList
GO

USE Project_WishList
GO

CREATE TABLE Usuarios
(
	idUsuario INT PRIMARY KEY IDENTITY,
	nomeUsuario VARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL,
	senha VARCHAR(15) NOT NULL,
	foto VARCHAR(255) NOT NULL
);
GO


CREATE TABLE Desejos
(
	idDesejo INT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES Usuarios(idUsuario),
	descricao VARCHAR(255) NOT NULL,
	dataCriacao DATE NOT NULL,
	prioridade BIT NOT NULL,
	favorito BIT NOT NULL
	
);
GO
