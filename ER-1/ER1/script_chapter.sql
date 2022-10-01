CREATE DATABASE Chapter;
USE Chapter;
CREATE TABLE Livros
(
	Id INT PRIMARY KEY IDENTITY,
	Titulos VARCHAR (150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);

INSERT INTO Livros (Titulos, QuantidadePaginas, Disponivel)
VALUES ('Titulo A', 120, 1);

INSERT INTO Livros (Titulos, QuantidadePaginas, Disponivel)
VALUES ('Titulo B', 220, 0);

INSERT INTO Livros (Titulos, QuantidadePaginas, Disponivel)
VALUES ('Titulo C', 225, 1);

SELECT * FROM Livros;

