create table pelicula(
	id int primary key identity,
	nombre_pelicula varchar(150) not null,
	fecha datetime not null,
	duracion time not null,
	category varchar(150) not null,
	estudio varchar(150) not null, 
	director varchar(150) not null,
	genero varchar(150) not null
);

create table rol(
	id int primary key identity,
	nombre varchar(150) not null,
	descrip varchar(250) not null,
	estado bit not null

);

create table persona (
	id int primary key identity, 
	nombre varchar(150) not null, 
	apellido varchar(150) not null,
	edad int not null, 
	telefono varchar(20) not null, 
	rol_id int not null, 

	foreign key (rol_id) references rol(id)
);

create table acceso_premier(
	id int primary key identity, 
	pelicula_id int not null, 
	persona_id int not null,

	foreign key (pelicula_id) references pelicula(id),
	foreign key (persona_id) references persona(id)

);

