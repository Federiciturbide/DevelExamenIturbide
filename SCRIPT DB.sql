use  DBDevel 



CREATE TABLE Encuestas(
IdEncuesta INT PRIMARY KEY NOT NULL,
Descripcion VARCHAR(50) NOT NULL,
Link VARCHAR(50) NOT NULL
);

CREATE TABLE Campos(
IdEncuesta INT NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Titulo VARCHAR(50) NOT NULL,
Requerido BIT NOT NULL,
Tipo VARCHAR(50) NOT NULL,

CONSTRAINT FK_Campos_Encuestas
FOREIGN KEY (IdEncuesta) REFERENCES Encuestas(IdEncuesta)
	ON UPDATE CASCADE
	ON DELETE CASCADE
);


DROP TABLE ENCUESTAS
DROP TABLE Campos
select*from Encuestas
select*from Campos
Select*from [dbo].[AspNetUsers]

