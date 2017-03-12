create table Libros(
LibrosId int identity(1,1) primary key,
Nombre varchar(50),
Edicion int,
Autores varchar(255),
AutoresId int,
);

create table Autores(
AutoresId int identity(1,1)primary key,
Nombre varchar(50),
);

create table LibroAutore(
LibroAutoreId int identity(1,1) primary key,
LibrosId int,
AutoresId int,
);