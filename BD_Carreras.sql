

create database Carreras

use Carreras

create table Carrera
(idCarrera int identity(1,1),
nombre varchar(50),
titulo varchar(50),
Constraint pk_idCarrera primary key (idCarrera)
)

create table Asignatura
(idAsignatura int identity(1,1),
nombre varchar(50),
Constraint pk_idAsignatura primary key (idAsignatura)
)

create table DetalleCarrera
(idDetalle int not null,
anioCursado int,
cuatrimestre int,
idAsignatura int,
idCarrera int,
Constraint pk_idDetalle primary key (idDetalle),
constraint fk_idAsignatura foreign key (idAsignatura)
	references Asignatura (idAsignatura),
constraint fk_idCarrera foreign key (idCarrera)
	references Carrera (idCarrera)
)



create procedure pa_cargarCombo
as
select *
from Asignatura


create proc pa_insertarMaestro
@nombre varchar(50),
@titulo varchar(50),
@IdCarrera int output
as
begin
insert into Carrera(nombre, titulo)
values (@nombre, @titulo);
SET @IdCarrera = SCOPE_IDENTITY();
end

alter procedure pa_InsertarDetalle
@idDetalle int,
@IdCarrera int,
@IdAsignatura int,
@cuatrimestre int,
@anioCursado int,
@activo bit
as
begin 
insert into DetalleCarrera(idDetalle,idCarrera,IdAsignatura,cuatrimestre,anioCursado,Activo)
values(@idDetalle,@IdCarrera,@IdAsignatura,@cuatrimestre,@anioCursado,@activo)
end


insert into Asignatura(nombre)
values('Inglés'), ('Programación'), ('Estadística')
alter table DetalleCarrera
add constraint pk_detalle_carrera primary key(idCarrera,idDetalle)

alter procedure pa_MostrarDetalleConsulta 
as
begin
select idDetalle,c.nombre,a.nombre Asignatura,anioCursado,cuatrimestre,Activo
from detalleCarrera as dc join carrera as c on dc.idCarrera=c.idCarrera
join Asignatura as a on a.idAsignatura=dc.idAsignatura
WHERE Activo=1
end

alter procedure pa_CargarComboCarrera
as
begin
select idCarrera,nombre
from Carrera
end

alter table detalleCarrera 
add Activo bit

select*
from DetalleCarrera
select*
from Carrera

create procedure pa_BajaLogica
@idCarrera int
as
begin
update DetalleCarrera set Activo=0 where idCarrera=@idCarrera
end

