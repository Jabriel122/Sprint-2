
DELETE FROM Filme WHERE IdFilme = 19

SELECT * FROM Filme
SELECT * FROM Genero

SELECT IdFilme, Titulo FROM Filme WHERE IdFilme = 2
SELECT IdFilme, Titulo FROM Filme WHERE IdFilme = 1

UPDATE Filme SET Titulo = ('Rogue One') WHERE IdFilme = 1

UPDATE Filme SET Titulo = ('Dont look up'), IdGenero = (6) WHERE IdFilme = 23

SELECT IdFilme, Filme.IdGenero, Titulo,Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero
