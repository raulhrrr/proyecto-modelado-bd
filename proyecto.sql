create database proyecto_clientes_proveedores;

use proyecto_clientes_proveedores;

create table proveedor (
	id int identity(1, 1)  not null,
	nombre varchar(50) not null,
	apellido varchar(50) null,
	direccion varchar(100) not null,
	telefono varchar(15) not null,
	email varchar(100) not null,
	nit_ced varchar(20) not null,
	contrasena varchar(20) not null,
	constraint pk_proveedor primary key (id)
);

create table producto (
	id int identity(1, 1) not null,
	id_proveedor int not null,
	nombre varchar(50) not null,
	precio decimal(18, 2) not null,
	cantidad int not null,
	constraint pk_producto primary key (id),
	constraint fk_producto_proveedor foreign key (id_proveedor) references proveedor(id)
);

create table cliente (
	id int identity(1, 1) not null,
	nombre varchar(50) not null,
	apellido varchar(50) null,
	direccion varchar(100) null,
	telefono varchar(15) not null,
	email varchar(100) not null,
	nit_ced varchar(20) not null,
	constraint pk_cliente primary key (id)
);
