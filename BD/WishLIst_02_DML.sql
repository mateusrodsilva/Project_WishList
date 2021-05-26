USE Project_WishList
GO 

INSERT INTO Usuarios(email,senha)
VALUES ('mateus@mateus.com'), ('mateus123'),
		('rafael@rafael.com'), ('rafael123'),
		('ruben@ruben.com'), ('ruben123'),
		('leandro@leandro.com'), ('leandro123');
GO

INSERT INTO Desejos(idUsuario,descricao)
VALUES (1), ('Morar na Europa'),
		(2), ('Morar no Exterior'),
		(3), (''),
		(4), ('');
GO