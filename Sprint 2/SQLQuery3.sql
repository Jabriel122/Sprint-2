
USE Filmes_Gabriel

DELETE FROM Filme WHERE IdFilme = 19

SELECT * FROM Filme
SELECT * FROM Genero

SELECT IdFilme, Titulo FROM Filme WHERE IdFilme = 2
SELECT IdFilme, Titulo FROM Filme WHERE IdFilme = 1

UPDATE Filme SET Titulo = ('Rogue One') WHERE IdFilme = 1

UPDATE Filme SET Titulo = ('Dont look up'), IdGenero = (10) WHERE IdFilme = 23
UPDATE Filme SET Titulo = ('The Last of Us'), IdGenero = (10) WHERE IdFilme = 26

SELECT IdFilme, Filme.IdGenero, Titulo,Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero 

SELECT IdFilme, Titulo, Filme.IdGenero, Genero.Nome FROM Filme WHERE IdFilme = 26

SELECT IdFilme, Filme.IdGenero, Titulo,Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero WHERE IdFilme = 26

CREATE Table Usuario
(
   IdUsuario INT PRIMARY KEY IDENTITY,
   Email VARCHAR(100),
   Senha VARCHAR(100),
   Permissao VARCHAR(30)
)

INSERT INTO Usuario(Email, Senha, Permissao)
VALUES ('gabriel@gmail.com', 'gab123', 'Administrador'),
       ('marcio@gmail.com', 'marcio', 'Comum')

SELECT * FROM Usuario