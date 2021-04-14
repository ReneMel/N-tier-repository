--Inserts

select *from persona
select * from rol;

insert into  rol(nombre,descripcion) values ('admin', 'pos es el admin');
insert into  rol(nombre,descripcion) values ('usuario', 'pos es un usuario');


--procedures


--listar 
create or alter proc listar
as 
select p.idpersona as ID , p.apellido as APELLIDO, p.nombre as NOMBRE, p.edad as EDAD, p.telefono as TELEFONO, r.nombre as ROL  
from persona p left join rol r 
on r.idrol=p.idrol
order by p.idpersona desc;
go; 


create or alter proc insertar_persona 
@nombre varchar(50), @apellido varchar(50), @edad int, @tel varchar(50)
as
insert into persona(nombre,apellido,edad,telefono,idrol) values(@nombre,@apellido, @edad,@tel,2); 
go;

exec insert_person @nombre='SasS', @apellido='TheCultist', @edad=22, @tel='79791515';
