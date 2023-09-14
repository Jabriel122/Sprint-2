INSERT INTO TipoUsuario
VALUES (NEWID(), 'Administrador'), (NEWID(), 'Comum')

SELECT * FROM TipoUsuario

INSERT INTO Usuario
VALUES (NEWID(), 'admin@admin.com', 'administrador', '0186D74E-3F2C-41C7-B8D5-46992480591C'), 
       (NEWID(), 'comum@comum.com', 'comum', 'DEA5B474-C12C-415B-81EF-389545161B35')

SELECT * FROM Usuario

INSERT INTO Estudio
VALUES (NEWID(), 'SENAI')

SELECT * FROM Estudio

INSERT INTO Jogo
VALUES (NEWID(), 'Ping Pong', 'Jogo divertido', '2023-01-23', 1.99, '0E79EC10-1008-4943-AC1A-75A56CD5ACC9')

SELECT * FROM Jogo