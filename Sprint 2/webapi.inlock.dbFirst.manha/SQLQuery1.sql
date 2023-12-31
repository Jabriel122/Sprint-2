CREATE DATABASE inlcok_games_dbFirst_manha 
USE inlcok_games_dbFirst_manha

CREATE TABLE Estudio
(
	IdEstudio UNIQUEIDENTIFIER PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL
)
CREATE TABLE Jogo
(
	IdJogo UNIQUEIDENTIFIER PRIMARY KEY,
	IdEstudio UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Estudio(IdEstudio),
	Nome VARCHAR(100) NOT NULL,
	Descricao VARCHAR(100) NOT NULL,
	DataLancamento DATE NOT NULL,
	Valor SMALLMONEY NOT NULL
)
CREATE TABLE TipoUsuario
(
	IdTipoUsuario UNIQUEIDENTIFIER PRIMARY KEY,
	Titulo VARCHAR(100) NOT NULL,
)
CREATE TABLE Usuario
(
	IdUsuario UNIQUEIDENTIFIER PRIMARY KEY,
	IdTipoUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario),
	Email VARCHAR(100) NOT NULL,
	Senha VARCHAR(100) NOT NULL
)

INSERT INTO Estudio
VALUES (NEWID(), 'SENAI'), (NEWID(), 'SESI'), (NEWID(), 'SEBRAE')

SELECT * FROM Estudio

INSERT INTO Jogo
VALUES (NEWID(), 'B57483EB-7CC0-4BD8-85BD-10666FD7FD48', 'PIN PONG', 'JOGO LEGAL', '2023-01-01', 500),
       (NEWID(), 'B57483EB-7CC0-4BD8-85BD-10666FD7FD48', 'JUCAMON', 'CA�A POKEMON', '2022-03-01', 2.99)

SELECT * FROM Jogo

INSERT INTO TipoUsuario
VALUES (NEWID(), 'administrador'), (NEWID(), 'comun')

SELECT * FROM TipoUsuario

INSERT INTO Usuario
VALUES (NEWID(), 'FAEF267C-0AB6-4E88-8EDB-2146800E6D9B', 'adm@adm.com', 'admin'),
	   (NEWID(), '9B94D0D0-32FE-4C38-8B02-6E842C7DEC02', 'comum@comum.com', 'comum')

SELECT * FROM Usuario