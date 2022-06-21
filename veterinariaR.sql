create database VeterinariaR
use VeterinariaR

create table Mascota
(
idmascota int primary key identity,
nombre varchar(20),
tipo varchar(15),
tamañocm float,
edad int,
idpropietario int
)


create table propietario(
idpropietario int primary key identity,
nombre varchar(30),
apellidos varchar(30),
edad int,
dni varchar(9),
activo bit
)
create table doctor(
iddoctor int primary key identity,
nombre varchar(30),
apellidos varchar(30),
dni varchar(9),
especialidad varchar(20)
)

create table citas(
idcita int primary key identity,
idmascota int,
enfermedad varchar(100), 
tratamiento varchar(100),
iddoctor int,
fecha date
)

drop table mascota
drop table propietario
drop table citas
drop table doctor

alter table Mascota
add constraint fk_idm
FOREIGN KEY(idpropietario) REFERENCES propietario (idpropietario)

alter table citas
add constraint fk_idC
FOREIGN KEY(idmascota) REFERENCES mascota (idmascota)

alter table citas
add constraint fk_idD
FOREIGN KEY(iddoctor) REFERENCES doctor (iddoctor)

/*
PROPIETARIOS DATOS
*/
insert into propietario(nombre,apellidos,edad,dni,activo) 
values ('Genaro','Robles Quintana','20','74940968','1')

insert into propietario(nombre,apellidos,edad,dni,activo) 
values ('Joshua','Robles Quintana','14','746852129','1')

insert into propietario(nombre,apellidos,edad,dni,activo) 
values ('Jhasmin','Robles Quintana','47','985394713','1')

select * from propietario

create proc ListarPropietario
as
select idpropietario, nombre+' '+apellidos as [Nombres] from propietario
go

create proc BuscarPropietario
@nombre varchar(20)
as
select * from propietario where nombre like @nombre
go

exec BuscarPropietario 'Genaro'

alter proc InsertarPropietario
@nombre varchar(20),
@apellidos varchar (30),
@edad int,
@dni varchar(9),
@activo bit
as
insert into propietario(nombre,apellidos,edad,dni,activo) 
values (@nombre,@apellidos,@edad,@dni,@activo)
go

alter proc ActualizarPropietario
@id int,
@nombre varchar(20),
@apellidos varchar (30),
@edad int,
@dni varchar(9),
@activo bit
as
update propietario set nombre=@nombre,apellidos=@apellidos,edad=@edad,dni=@dni,activo=@activo
where idpropietario = @id
go

create proc EliminarPropietario
@id int
as
delete from propietario where idpropietario = @id
go

select * from propietario
/*
MASCOTAS
*/
insert into Mascota(nombre,tipo,tamañocm,edad,idpropietario) 
values ('Rodrigo','Perro','100','24','2')

insert into Mascota(nombre,tipo,tamañocm,edad,idpropietario) 
values ('Pechechuelo','Pez Tilapia','8','24','3')

create proc BuscarMascota
@nombre varchar(20)
as
select * from Mascota where nombre like @nombre
go

exec BuscarMascota 'pechechuelo'


create proc InsertarMascota
@nombre varchar(20),
@tipo varchar (20),
@tam int,
@edad int,
@idpropietario int
as
insert into Mascota(nombre,tipo,tamañocm,edad,idpropietario) 
values (@nombre,@tipo,@tam,@edad,@idpropietario)
go

create proc ActualizarMascota
@id int,
@nombre varchar(20),
@tipo varchar (20),
@tam int,
@edad int,
@idpropietario int
as
update Mascota set nombre=@nombre,tipo=@tipo,tamañocm=@tam,edad=@edad,idpropietario=@idpropietario
where idmascota = @id
go

create proc EliminarMascota
@id int
as
delete from Mascota where idmascota = @id
go

select * from Mascota

/*
DOCTOR
*/

insert into doctor(nombre,apellidos,dni,especialidad) 
values ('Francisco','Sagasti','123456789','Microbiologia')

insert into doctor(nombre,apellidos,dni,especialidad) 
values ('Martin','Vizcarra','923456781','Ictiopatologia')

create proc BuscarDoctor
@nombre varchar(20)
as
select * from doctor where nombre like @nombre
go

exec BuscarDoctor 'Francisco'

create proc InsertarDoctor
@nombre varchar(20),
@apellidos varchar (20),
@dni varchar(9),
@especialidad varchar(20)
as
insert into doctor(nombre,apellidos,dni,especialidad) 
values (@nombre,@apellidos,@dni,@especialidad)
go

create proc ActualizarDoctor
@id int,
@nombre varchar(20),
@apellidos varchar (20),
@dni varchar(9),
@especialidad varchar(20)
as
update doctor set nombre=@nombre,apellidos=@apellidos,dni=@dni,especialidad=@especialidad
where iddoctor = @id
go

create proc EliminarDoctor
@id int
as
delete from doctor where iddoctor = @id
go

select * from doctor

/*
CITAS
*/

create proc ListarMascotaCita
as
select idmascota,nombre from Mascota
go

create proc ListarDoctorCita
as
select iddoctor,nombre+' '+apellidos as [nombres] from doctor
go

alter proc InsertarCita
@idmascota int,
@efermedad varchar(100),
@tratamiento varchar(100),
@iddoctor int,
@fecha datetime
as
insert into citas (idmascota,enfermedad,tratamiento,iddoctor,fecha)
values (@idmascota,@efermedad,@tratamiento,@iddoctor,@fecha)
go

alter proc CitasFecha
@fecha1 datetime, @fecha2 datetime, @mascota int
as
begin
select c.idcita,c.fecha,d.nombre+' '+d.apellidos as [Nombre completo]
from citas c inner join doctor d on c.iddoctor = d.iddoctor
where c.idmascota = @mascota and fecha between @fecha1 and @fecha2
end

alter proc DetallesCitas
@id int = 0
as
BEGIN
    IF(@id = 0)
        BEGIN
			select c.idcita,c.fecha,d.nombre+' '+d.apellidos as [Nombre completo],
			m.nombre,c.enfermedad, c.tratamiento
			from citas c inner join doctor d on c.iddoctor = d.iddoctor
			inner join Mascota m on c.idmascota = m.idmascota
			order by c.idcita
		END
    ELSE
        BEGIN
			select c.idcita,c.fecha,d.nombre+' '+d.apellidos as [Nombre completo],
			m.nombre,c.enfermedad, c.tratamiento
			from citas c inner join doctor d on c.iddoctor = d.iddoctor
			inner join Mascota m on c.idmascota = m.idmascota
			where idcita = @id
		END
end


alter proc PropMascota
as
select m.idmascota, m.nombre,m.tipo, m.tamañocm, m.edad, p.idpropietario, p. nombre+' '+p.apellidos as [nombres], p.edad, p.dni
from Mascota m inner join propietario p on m.idpropietario = p.idpropietario
order by p.idpropietario
go


select * from citas