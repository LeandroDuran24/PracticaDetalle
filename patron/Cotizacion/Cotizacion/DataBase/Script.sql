create table Produtos(
ProductoId int identity(1,1) primary key,
Nombre varchar(25),
);

create table Clientes(
ClienteId int identity(1,1)primary key,
Nombre varchar(25),
Direccion varchar(45),
Producto varchar(25),
ProductoId int,
);

create table ClienteProductos(
ClienteProductoId int  identity(1,1) primary key,
ProductoId int,
ClienteId int,
);

