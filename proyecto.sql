create database proyecto;

use proyecto;

create table categoria (
	id int identity(1, 1) not null,
	nombre varchar(100) not null,
	descripcion varchar(500) null,
	constraint pk_categoria primary key (id)
);

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

create table proveedor_categoria (
	id int not null,
	id_proveedor int not null,
	id_categoria int not null,
	constraint pk_relacion_proveedor_categoria primary key (id)
);

create table producto (
	id int identity(1, 1) not null,
	id_proveedor int not null,
	nombre varchar(50) not null,
	precio decimal(18, 2) not null,
	cantidad int not null,
	constraint pk_producto primary key (id)
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

create table proveedor_cliente (
	id int not null,
	id_proveedor int not null,
	id_cliente int not null,
	estado bit not null,
	constraint pk_relacion_proveedor_cliente primary key (id)
);
