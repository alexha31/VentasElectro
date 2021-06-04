CREATE DATABASE bd_ventas

use bd_ventas

CREATE TABLE Catalogo(
	Codigo INT PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Precio FLOAT NOT NULL 
);

CREATE TABLE Factura(
	Codigo INT PRIMARY KEY,
	Cliente VARCHAR(100) NOT NULL,
	Fecha VARCHAR(100) NOT NULL
);

CREATE TABLE Producto(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Codigo INT NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Precio FLOAT NOT NULL,
	Cantidad INT NOT NULL,
	Fk_Codigo int FOREIGN KEY REFERENCES Factura(Codigo)
);

INSERT INTO Catalogo VALUES(10,'Televisor',9000);
INSERT INTO Catalogo VALUES(11,'Laptop DELL',15000);
INSERT INTO Catalogo VALUES(12,'Refrigeradora',20000);
INSERT INTO Catalogo VALUES(13,'Abanico',900);
INSERT INTO Catalogo VALUES(14,'Plancha',2000);
INSERT INTO Catalogo VALUES(15,'Cocina',10000);

INSERT INTO Factura VALUES (1, 'Carmen Salinas', '10-Octubre-2015');
INSERT INTO Factura VALUES (2, 'Luis Martinez','15-Mayo-2017');
INSERT INTO Factura VALUES (3, 'Roger Perez','20-Enero-2016');


INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(10,'Televisor',9000,2,1);
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(11,'Laptop DELL',15000,3,1);
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(12,'Refrigeradora',20000,4,1);
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(13,'Abanico',900,5,2);
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(14,'Plancha',2000,6,2);
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(10,'Televisor',9000,5,3);
INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES(14,'Plancha',2000,2,3);