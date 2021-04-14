
create table rol (

idrol int primary key identity,
nombre varchar(50) NOT NULL,
descripcion varchar(255)NULL,
estado bit default (1)

);

create table persona (

idpersona int primary key identity,
nombre varchar(50)NOT NULL, 
apellido varchar(150)NOT NULL,
edad int NOT NULL,
telefono int NULL,
idrol int NOT NULL,


foreign key (idrol) references rol(idrol)
);

