Create database Autos;

use Autos;

create table Marca(
Id int identity(1,1) primary key,
Marca varchar(20),
);

create table Modelo(
Id int identity(1,1) primary key,
Modelo varchar(20),
Id_Marca int,
Foreign key (Id_Marca) References Marca(Id),
);

create table precios(
Id int identity(1,1) primary key,
Costo money,
Precio money,
Utilidad as Precio-Costo,
Id_Modelo int,
Foreign key (Id_Modelo) References Modelo(Id)
);


insert into Marca values('Toyota');
insert into Marca values('Nissan');
insert into Marca values('hunday');

insert into Modelo values('Yaris', 1);
insert into Modelo values('Supra', 1);
insert into Modelo values('acent', 3);
insert into Modelo values('versa', 2);

select * from Modelo join Marca on modelo.Id_Marca = Marca.Id join precios on precios.Id_Modelo = Modelo.Id; 

insert into precios values(1500.00, 1900.00, 1);
insert into precios values(2000.00, 3000.00, 2);
insert into precios values(6000.00, 9000.00, 3);
insert into precios values(6000.00, 9500.00, 4);	
insert into precios values(17000, 20000, 5);

select * from Modelo;
select * from Marca;
select * from precios;

select Modelo.Modelo, Modelo.Id_Marca, Marca.Marca, precios.Costo, precios.Precio, precios.Utilidad, precios.Id_Modelo 
from Modelo join Marca on Modelo.Id_Marca = Marca.Id
join precios on precios.Id_Modelo = Modelo.Id;

select * from Modelo 
join Marca on Modelo.Id = Marca.Id
join precios on Modelo.Id = precios.Id_Modelo;




drop database Autos;