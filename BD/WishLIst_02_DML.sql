USE Project_WishList
GO 

INSERT INTO Usuarios(nomeUsuario,email,senha,foto)
VALUES ('Mateus Rodrigues','mateus@mateus.com','mateus123','padrao.png'),
		('Rafael Gomes','rafael@rafael.com','rafael123','padrao.png'),
		('Ruben','ruben@ruben.com','ruben123','padrao.png'),
		('Leandro Rangel','leandro@leandro.com','leandro123','padrao.png');
GO

INSERT INTO Desejos(idUsuario,descricao,dataCriacao,prioridade,favorito)
VALUES (1,'Morar na Europa','27-05-2021',1,1),
		(2,'Morar no Exterior','27-05-2021',1,1),
		(3,'Ter muito dinheiro','27-05-2021',1,1),
		(4,'Viajar pelo mundo','27-05-2021',1,1);
GO