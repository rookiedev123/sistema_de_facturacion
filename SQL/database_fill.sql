insert into clientes (cliente_id, nombreCompleto)
values
('123456789', 'Juan Pérez'),
('987654321', 'María López'),
('456789123', 'Carlos Sánchez');
go
insert into productos (codigo, descripcion, precio, descuento)
values
('PROD001', 'Laptop Dell XPS', 1500.000, 0.10),
('PROD002', 'Mouse Logitech', 25.000, 0.00),
('PROD003', 'Monitor Samsung 27"', 300.000, 0.05),
('PROD004', 'Teclado Mecánico', 80.000, 0.02);
go
insert into facturas (cliente_id, total)
values
('123456789', 1825.000),
('987654321', 325.000),
('456789123', 500.000);
go
-- Factura 1
insert into facturas_productos (factura_id, codigo, cantidad, total_descuento, total_pagar)
values
(1, 'PROD001', 1, 150.000, 1350.000),  -- Laptop con 10% descuento
(1, 'PROD002', 1, 0.000, 25.000),
(1, 'PROD003', 1, 15.000, 285.000);
go

-- Factura 2
insert into facturas_productos (factura_id, codigo, cantidad, total_descuento, total_pagar)
values
(2, 'PROD003', 1, 15.000, 285.000),
(2, 'PROD004', 1, 1.600, 78.400);
go

-- Factura 3
insert into facturas_productos (factura_id, codigo, cantidad, total_descuento, total_pagar)
values
(3, 'PROD001', 1, 150.000, 1350.000),
(3, 'PROD004', 2, 3.200, 156.800);
go
select 
    f.factura_id,
    c.cliente_id,
    c.nombreCompleto,
    p.codigo,
    p.descripcion,
    fp.cantidad,
    fp.total_descuento,
    fp.total_pagar
from facturas_productos fp
inner join facturas f on fp.factura_id = f.factura_id
inner join clientes c on f.client_id = c.client_id
inner join productos p on fp.codigo = p.codigo
order by f.factura_id;
go