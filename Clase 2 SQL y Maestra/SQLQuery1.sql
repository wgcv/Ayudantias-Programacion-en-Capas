Select * from productos
Select nombre, caracteristicas from productos
select nombre from productos where inflamable = 'S' And cantidad < 50.00
update productos set estado = 'I' where codigo = 1
select * from productos where estado = 'A'
delete from productos where codigo = 1
insert INTO productos (nombre, unidad,caracteristicas, inflamable, cantidad, marca,estado) Values ('MADERA', 'METROS', 'DURO', 'S', '30', 'EL BOSQUE', 'A')