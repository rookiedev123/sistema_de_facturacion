create table clientes(
	cliente_id varchar(50),
	creado_en datetime DEFAULT GETDATE(),
	nombreCompleto varchar(500) not null,
	constraint PK_client_id primary key(client_id),
);
go
create table productos(
	codigo varchar(15) ,
	creado_en DATETIME DEFAULT GETDATE(),
	descripcion varchar(200) not null,
	precio decimal(12,3) not null,
	descuento decimal(3,2) default 0,
	constraint PK_pcodigo primary key(codigo)

);
go
create table facturas(
	factura_id int identity(1,1),
	creado_en datetime DEFAULT GETDATE(),
	cliente_id varchar(50) not null,
	tipo_pago varchar(50) not null,
	total decimal(15,3) not null,
	constraint PK_factura_id primary key(factura_id),
	constraint FK_client_id foreign key (cliente_id) references clientes(cliente_id) 
);
go
create table facturas_productos(
	factura_id int not null,
	codigo varchar(15) not null,
	cantidad decimal(12,3) not null,
	total_descuento decimal(15,3) not null,
	total_pagar decimal(15,3) not null,
	constraint FK_factura_productos_factura_id foreign key (factura_id) references facturas(factura_id),
	constraint FK_factura_productos_codigo foreign key (codigo) references productos(codigo),
	constraint PK_factura_productos_factura primary key(factura_id,codigo),


);