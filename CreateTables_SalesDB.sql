CREATE DATABASE db_Ntiers;

--categoria
CREATE TABLE category(
	id int primary key identity,
	name varchar(50) NOT NULL unique,
	description varchar(255) NULL, 
	state bit default(1)
);

--Producto
CREATE TABLE product(
	id integer primary key identity,
	id_category integer NOT NULL,
	code varchar(50) NULL,
	name varchar(100) NOT NULL unique,
	price decimal(11, 2) NOT NULL ,
	stock int NOT NULL,
	description varchar(255) NULL,
	image varchar(20) NULL,
	state bit default(1),

	foreign key (id_category) references category(id)
);

--Persona
CREATE TABLE person(
	id integer primary key identity,
	type varchar(20) NOT NULL,
	name varchar(100) NOT NULL,
	document_type varchar(20) NULL,
	document_num varchar(20)  NULL,
	address varchar(70) NULL,
	phone_number varchar(20) NULL,
	email varchar(50) NULL
);

--Roles
CREATE TABLE role(
	id int primary key identity,
	name varchar(30) NOT NULL unique,
	description varchar(255) NULL,
	state bit default(1)
);


--Usuario
CREATE TABLE users(
	id int primary key identity,
	id_role integer NOT NULL,
	name varchar(100) NOT NULL,
	document_type varchar(20) NULL,
	document_num varchar(20)  NULL,
	address varchar(70) NULL,
	phone_number varchar(20) NULL,
	email varchar(50) NULL,
	password varbinary(MAX) NOT NULL,
	state bit default(1),

	foreign key  (id_role) references role (id)
);

--Entradas
CREATE TABLE entries(
	id int primary key identity,
	id_supplier int NOT NULL,
	id_user int  NOT NULL,
	receipt_type varchar(20) NOT NULL,
	receipt_serie varchar(7) NULL,
	receipt_num varchar(10) NOT NULL,
	date datetime NOT NULL,
	tax decimal(4,2) NOT NULL,
	total decimal(11,2) NOT NULL,
	state varchar(20) NOT NULL,

	FOREIGN KEY (id_supplier) REFERENCES person(id),
	FOREIGN KEY (id_user) REFERENCES users(id)
);

--Entries detail table
CREATE TABLE entries_detail(
	id int primary key identity,
	id_entries int NOT NULL,
	id_product int NOT NULL,
	quant int NOT NULL,
	price decimal (11,2) NOT NULL,

	FOREIGN KEY (id_entries) REFERENCES entries(id),
	FOREIGN KEY (id_product) REFERENCES product(id) ON DELETE CASCADE
);

--Sale table
CREATE TABLE sale(
	id int primary key identity,
	id_client int NOT NULL,
	id_user int NOT NULL,
	receipt_type varchar(20) NOT NULL,
	receipt_serie varchar(7) NULL,
	receipt_num varchar(10) NOT NULL,
	date datetime NOT NULL,
	tax decimal(4,2) NOT NULL,
	total decimal (11,2) NOT NULL,
	state varchar(20) NOT NULL,

	FOREIGN KEY (id_client) REFERENCES person(id),
	FOREIGN KEY (id_user) REFERENCES users(id)
);

--Sale detail table
CREATE TABLE sale_detail(
	id int primary key identity,
	id_sale int NOT NULL,
	id_product int NOT NULL,
	quantity int NOT NULL,
	price decimal(11,2) NOT NULL,
	disccount decimal (11,2) NOT NULL,
	
	FOREIGN KEY (id_sale) REFERENCES sale(id),
	FOREIGN KEY (id_product) REFERENCES product(id)
);