create table clientes(
	documentId varchar(50),
	creado_en datetime DEFAULT GETDATE(),
	nombreCompleto varchar(500) not null,
	constraint PK_document_id primary key(documentId),
);
go
create table productos(
	producto_id int identity(1,1),
	creado_en DATETIME DEFAULT GETDATE(),
	codigo varchar(15) unique not null,
	descripcion varchar(200) not null,
	precio decimal(12,3) not null,
	descuento decimal(3,2) default 0,
	constraint PK_producto_id primary key(producto_id)

);
go
create table facturas(
	factura_id int identity(1,1),
	creado_en datetime DEFAULT GETDATE(),
	documentId varchar(50) not null,
	total decimal(15,3) not null,
	constraint PK_factura_id primary key(factura_id),
	constraint FK_document foreign key (documentId) references clientes(documentId) 
);
go
create table facturas_productos(
	factura_id int not null,
	producto_id int not null,
	cantidad decimal(12,3) not null,
	total_descuento decimal(15,3) not null,
	total_pagar decimal(15,3) not null,
	constraint FK_factura_productos_factura_id foreign key (factura_id) references facturas(factura_id),
	constraint FK_factura_productos_producto_id foreign key (producto_id) references productos(producto_id),
	constraint PK_factura_productos_factura primary key(factura_id,producto_id),


);