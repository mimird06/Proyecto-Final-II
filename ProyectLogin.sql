create database ProyectLogin
go

use ProyectLogin
go

create table usuario 
(
	id_usuario varchar(4),
	nombre varchar(50),
	n_usuario varchar(30),
	clave varchar(30)
);

insert into usuario values ('0001', 'Thammy', 'mimird06', 'tiecsti');
insert into usuario values ('0002', 'Franceily', 'franvargas', '12345');
insert into usuario values ('0003', 'Tomas', 'tomasfvh', 'viveres');
insert into usuario values ('0004', 'Prueba', 'usuario1', 'itla123');

create proc iniciar_sesion
@nombre_us varchar(30),
@contrasena varchar(30)
as
select id_usuario, nombre, n_usuario, clave from usuario
where n_usuario=@nombre_us and clave=@contrasena
go