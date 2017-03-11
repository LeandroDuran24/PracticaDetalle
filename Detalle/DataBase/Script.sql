create table Estudiantes(
EstudianteId int identity(1,1) primary key,
Nombre varchar(80),
Carrera varchar (80),
);

create table Materias(
MateriaId int identity(1,1) primary key, 
Nombre varchar(80));


create table EstudianteMateria( EstudianteMateria int identity (1,1) primary key,
EstudianteId int , 
MateriaId int ,
);
