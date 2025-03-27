USE DBVENTASDEMO
go

create table ROL(
IdRol int primary key identity,
Descripcion varchar(50),
FechaCreacion datetime default getdate()
)
go

create table PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaCreacion datetime default getdate()
)
go

Create table PROVEEDOR (
IdProveedor int identity primary key,
Documento varchar(50),
RazonSocial varchar(50),
Correo varchar(50),
Telefono varchar(50),
FechaCreacion datetime default getdate()
)
GO

CREATE TABLE CLIENTE(
	IdCliente int primary key identity,
	Placa varchar(20),
	NombreCompleto varchar(35),
	Ruc Varchar(20),
	Telefono varchar(12),
	Correo varchar(50),
	Documento varchar(20),
	FechaCreacion datetime default getdate()
)
go

CREATE TABLE USUARIO(
	IdUsuario int primary key identity,
	Documento varchar(15),
	NombreCompleto varchar(35),
	Correo varchar(30),
	Clave varchar(50),
	IdRol int references ROL(IdRol),
	Estado bit,
	FechaRegistro datetime default getdate()
)
go

CREATE TABLE CATEGORIA(
	IdCategoria int primary key identity,
	Descripcion varchar(40),
	Estado bit,
	FechaRegistro datetime default getdate()
)
go


CREATE TABLE PRODUCTO (
	IdProducto  int primary key identity,
	Codigo varchar(25),
	Nombre varchar(30),
	Descripcion varchar(40),
	IdCategoria int references CATEGORIA(IdCategoria),
	Ubicacion varchar(100)null,
	Stock int not null default 0,
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2)default 0,
	UnidadMedida varchar(10) null,	
	FechaRegistro varchar(25)
)
go

CREATE TABLE COMPRA(
	IdCompra  int primary key identity,
	IdUsuario int references USUARIO(IdUsuario),
	IdProveedor int references PROVEEDOR(IdProveedor),
	TipoDocumento varchar(50),
	TipoPago varchar(500),
	NumeroDocumento varchar(50),
	MontoTotal decimal(10,2),
	FechaCreacion datetime default getdate()
)
go

CREATE TABLE DETALLE_COMPRA (
	IdDetelleCompra int identity primary key,
	IdCompra int references COMPRA (IdCompra),
	IdProducto int references PRODUCTO(IdProducto),
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2)default 0,
	Cantidad int,
	MontoTotal decimal (10,2),
	FechaRegistro datetime default getdate()
)
go

CREATE TABLE VENTA (
	IdVenta int identity primary key,
	NumeroDocumento varchar(50) null,
	Placa varchar(20)null,
	NombreCliente varchar(100),
	TipoDocumento varchar(50),
	TipoPago varchar(500),
	Ruc varchar (50),
	Kilometraje int null,
	MontoPago decimal(10,2),
	MontoCambio decimal(10,2),
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
go

CREATE TABLE DETALLE_VENTA(
	IdDetalleVenta int identity primary key,
	IdVenta int references VENTA (IdVenta),
	IdProducto int references PRODUCTO(IdProducto),
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	SubTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
go

create table SERVICIO(
IdServicio int identity primary key,
Descripcion varchar(500),
)
go

CREATE TABLE VENTA_SERVICIO (
	IdVentaServicio int identity primary key,
	NumeroDocumento varchar(50) null,
	Placa varchar(20)null,
	NombreCliente varchar(100),
	TipoDocumento varchar(50),
	TipoPago varchar(500), 
	Ruc varchar (50),
	Kilometraje int null,
	MontoPago decimal(10,2),
	MontoCambio decimal(10,2),
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
go

CREATE TABLE DETALLE_SERVICIO(
	IdDetalleServicio int identity primary key,
	IdVentaServicio int references VENTA_SERVICIO (IdVentaServicio),
	IdServicio int references SERVICIO(IdServicio),
	Descripcion varchar(50),
	PrecioServicio decimal(10,2) default 0,	
	FechaRegistro datetime default getdate()
)
go

create table NEGOCIO(
IdNegocio int primary key,
Nombre varchar(60),
RUC varchar(60),
Direccion varchar(60),
Logo varbinary(max) NULL
)
go

 CREATE TABLE COTIZACION (
	IdCotizacion int identity primary key,
	Placa varchar(20)null,
	NombreCliente varchar(100),
	TipoDocumento varchar(50),
	Descripcion varchar(400),
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
go

CREATE TABLE DETALLE_COTIZACION(
	IdDetalleCotizacion int identity primary key,
	IdCotizacion int references COTIZACION (IdCotizacion),
	IdProducto int references PRODUCTO(IdProducto),
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	SubTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
go

--------------------------------------------SER
CREATE TABLE SERCOTIZACION (
	IdCotizacion int identity primary key,
	Placa varchar(20)null,
	NombreCliente varchar(100),
	TipoDocumento varchar(50),
	DetalleDescripcion varchar(400),
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
go


CREATE TABLE DETALLE_SERCOTIZACION(
	IdDetalleSERCotizacion int identity primary key,
	IdCotizacion int references SERCOTIZACION (IdCotizacion),
	IdServicio int references SERVICIO(IdServicio),
	Descripcion varchar(50),
	PrecioServicio decimal(10,2) default 0,
	FechaRegistro datetime default getdate()
)
go
/*--------------------------------------------------------------------------------------------*/

go

CREATE PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO WHERE Documento = @Documento)
	begin 
		insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)values
		(@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)
		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede puede repetir el documento para mas de un Usuario'

end

go

------------------------------editarusuario----------------
create PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists(select * from USUARIO WHERE Documento = @Documento and idusuario != @IdUsuario)
	begin 
		update usuario set
		Documento=@Documento,
		NombreCompleto =@NombreCompleto,
		Correo =@Correo,
		Clave =@Clave,
		IdRol =@IdRol,
		Estado =@Estado
		where IdUsuario =@IdUsuario
		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede puede repetir el documento para mas de un Usuario'

end
go

---eliminar usuario-----

create PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS( SELECT * FROM COMPRA c
	INNER JOIN USUARIO U on U.IdUsuario =C.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN 
		SET @pasoreglas = 0
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar por que el usuario esta relaciondo a una COMPRA\n'
	END

	

	if (@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario 
		set @Respuesta =1 
	end

end
go

----------------------------------------------------------------------------------------------------------------------
--------------PROCEDIMIENTOS CATEGORIAS-------------------------------------------------------------------------
------CATEGORIA----------

CREATE PROC SP_RegistrarCategoria(
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	begin
		insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	
end
GO

---------------EDITARCATEGORIA-------------------
Create procedure SP_EditarCategoria(
@IdCategoria int,
@Descripcion varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion =@Descripcion and IdCategoria != @IdCategoria)
		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	end

end
GO

----------ELIINAR CATEGORIA---------------
create procedure SP_EliminarCategoria(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from CATEGORIA c
	 inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	 where c.IdCategoria = @IdCategoria
	)
	begin
	 delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'La categoria se encuentara relacionada a un producto'
	end

end
GO

------------------------------- PRODUCTO-------------------------
 --------------------REGISTAR PRODUCTO--------------------------------
CREATE PROC SP_RegistrarProducto(
@Codigo varchar(20),
@Descripcion varchar(1000),
@Stock int,
@Ubicacion varchar(100),
@PrecioVenta decimal(10,2),
@PrecioCompra decimal(10,2),
@UnidadMedida varchar(10),
@IdCategoria int,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
	begin
		insert into producto(Codigo,Descripcion,Stock,Ubicacion,PrecioVenta,PrecioCompra,UnidadMedida,IdCategoria) 
		values (@Codigo,@Descripcion,@Stock,@Ubicacion,@PrecioVenta,@PrecioCompra,@UnidadMedida,@IdCategoria)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
	 SET @Mensaje = 'Ya existe un producto con el mismo codigo' 
	
end

GO
-----------------------
----------------------MODIFICAR PRODUCTO----------------------

CREATE procedure SP_ModificarProducto(
@IdProducto int,
@Codigo varchar(20),
@Descripcion varchar(1000),
@Stock int,
@Ubicacion varchar(100),
@PrecioVenta decimal(10,2),
@PrecioCompra decimal(10,2),
@UnidadMedida varchar(10),
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE codigo = @Codigo and IdProducto != @IdProducto)
		
		update PRODUCTO set
		codigo = @Codigo,		
		Descripcion = @Descripcion,
		Stock = @Stock,
		Ubicacion= @Ubicacion,
		PrecioVenta = @PrecioVenta,
		PrecioCompra = @PrecioCompra,
		UnidadMedida = @UnidadMedida,
		IdCategoria = @IdCategoria		
		where IdProducto = @IdProducto
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe un producto con el mismo codigo' 
	end
end

go

-----------------ELIMINAR PRODUCTO-------------------------

create PROC SP_EliminarProducto(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DETALLE_COMPRA dc 
	INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n' 
	END

	IF EXISTS (SELECT * FROM DETALLE_VENTA dv
	INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1 
	end

end
go

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/

create PROC sp_RegistrarCliente(
@Placa varchar(20),
@NombreCompleto varchar(50),
@Ruc varchar(20),
@Telefono varchar(50),
@Correo varchar(50),
@Documento varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Placa = @Placa)
	begin
		insert into CLIENTE(Placa,NombreCompleto,Ruc,Telefono,Correo,Documento) values (
		@Placa,@NombreCompleto,@Ruc,@Telefono,@Correo,@Documento)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

go

------------------------MODIFICAR CLIENTE----------------------

create PROC sp_ModificarCliente(
@IdCliente int,
@Placa varchar(20),
@NombreCompleto varchar(50),
@Ruc varchar(20),
@Telefono varchar(50),
@Correo varchar(50),
@Documento varchar(50),
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Placa = @Placa and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Placa = @Placa,
		NombreCompleto = @NombreCompleto,
		Ruc = @Ruc,
		Telefono = @Telefono,
		Correo = @Correo,
		Documento = @Documento
		where IdCliente = @IdCliente
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end

go

/* ---------- PROCEDIMIENTOS PARA PROVEEDOR -----------------*/
    ----------REGISTRAR PORVEEDOR---------------------------------------------

create PROC sp_RegistrarProveedor(
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin
		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono) values (
		@Documento,@RazonSocial,@Correo,@Telefono)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

GO

-------------------------MODIFICAR PORVEEDOR-------------------------------

Create PROC sp_ModificarProveedor(
@IdProveedor int,
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono
		 
		where IdProveedor = @IdProveedor
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end


go

--------------------------ELIMINARPORVEEDOR-------------------------

create procedure sp_EliminarProveedor(
@IdProveedor int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from PROVEEDOR p
	 inner join COMPRA c on p.IdProveedor = c.IdProveedor
	 where p.IdProveedor = @IdProveedor
	)
	begin
	 delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'El proveedor se encuentara relacionado a una compra'
	end

end

go

---------------------------COMPRA------------------------------------------
CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
)

GO

create PROCEDURE sp_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@TipoPago varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try

		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into COMPRA(IdUsuario,IdProveedor,TipoDocumento,NumeroDocumento,MontoTotal,TipoPago)
		values(@IdUsuario,@IdProveedor,@TipoDocumento,@NumeroDocumento,@MontoTotal,@TipoPago)

		set @idcompra = SCOPE_IDENTITY()

		insert into DETALLE_COMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
		select @idcompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra


		update p set p.Stock = p.Stock + dc.Cantidad, 
		p.PrecioCompra = dc.PrecioCompra,
		p.PrecioVenta = dc.PrecioVenta
		from PRODUCTO p
		inner join @DetalleCompra dc on dc.IdProducto= p.IdProducto

		commit transaction registro


	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end
GO

-------------------------VENTA---------------------

create TYPE [dbo].[EDetalle_Venta] AS TABLE (
    [IdProducto] INT NULL,
	[PrecioVenta] DECIMAL(18,2) NULL,
    [Cantidad] INT NULL,
    [SubTotal] DECIMAL(18,2) NULL
)
GO

create PROCEDURE usp_RegistrarVenta (
    @TipoDocumento varchar(500),
	@TipoPago varchar(500),
    @NumeroDocumento varchar(500),
    @NombreCliente varchar(500),
    @Placa varchar(100),
	@Ruc varchar(20),
	@Kilometraje int,
    @MontoPago decimal(18,2),
    @MontoCambio decimal(18,2),
    @MontoTotal decimal(18,2),
    @DetalleVenta [EDetalle_Venta] READONLY,
    @Resultado bit OUTPUT,
    @Mensaje varchar(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @idventa int = 0;
        SET @Resultado = 1;
        SET @Mensaje = '';

        BEGIN TRANSACTION registro;

        -- Inserta en la tabla VENTA, referenciando al IdCliente existente o recién creado
        INSERT INTO VENTA(TipoDocumento, NumeroDocumento, NombreCliente, Placa, MontoPago, MontoCambio, MontoTotal,Ruc,Kilometraje,TipoPago)
        VALUES(@TipoDocumento, @NumeroDocumento, @NombreCliente, @Placa, @MontoPago, @MontoCambio, @MontoTotal,@Ruc,@Kilometraje,@TipoPago)

        -- Obtiene el ID de la venta recién ;insertada
        SET @idventa = SCOPE_IDENTITY();

        -- Inserta en la tabla DETALLE_VENTA, incluyendo Kilometraje y Descripcion
        INSERT INTO DETALLE_VENTA (IdVenta, IdProducto,PrecioVenta, Cantidad, SubTotal)
		SELECT @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal
		FROM @DetalleVenta;

        COMMIT TRANSACTION registro
		SET @Mensaje = 'Venta registrada exitosamente.';
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registro
    END CATCH
END
GO

------------------------------------SERVICIO----------------------

CREATE TYPE [dbo].[eDETALLE_SERVICIO] AS TABLE (    
	[Descripcion] Varchar(500),
	[PrecioServicio] DECIMAL(18,2) NULL
)
GO

create PROCEDURE usp_RegistrarVentaServicio(
    @TipoDocumento varchar(500),
	@TipoPago varchar(500),
    @NumeroDocumento varchar(500),
    @NombreCliente varchar(500),
    @Placa varchar(100),
	@Ruc varchar(20),
	@Kilometraje int,
    @MontoPago decimal(18,2),
    @MontoCambio decimal(18,2),
    @MontoTotal decimal(18,2),
    @Detalleservicio [eDETALLE_SERVICIO] READONLY,
    @Resultado bit OUTPUT,
    @Mensaje varchar(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @idventaservicio int = 0;
		DECLARE @idcliente INT = 0;
        SET @Resultado = 1;
        SET @Mensaje = '';

        BEGIN TRANSACTION registro;      
		
        -- Inserta en la tabla VENTA, referenciando al IdCliente existente o recién creado
        INSERT INTO VENTA_SERVICIO(TipoDocumento, NumeroDocumento, NombreCliente, Placa, MontoPago, MontoCambio, MontoTotal,Ruc,Kilometraje,TipoPago)
        VALUES(@TipoDocumento, @NumeroDocumento, @NombreCliente, @Placa, @MontoPago, @MontoCambio, @MontoTotal,@Ruc,@Kilometraje,@TipoPago)


        -- Obtiene el ID de la venta recién ;insertada
        SET @idventaservicio = SCOPE_IDENTITY();

		INSERT INTO SERVICIO (Descripcion)
        SELECT DISTINCT Descripcion
        FROM @Detalleservicio
        WHERE Descripcion NOT IN (SELECT Descripcion FROM SERVICIO);

         -- Paso 3: Insertar en DETALLE_VENTA, vinculando IdServicio desde la tabla SERVICIO
        INSERT INTO DETALLE_SERVICIO (IdVentaServicio, IdServicio, Descripcion, PrecioServicio)
        SELECT 
            @idventaservicio, 
            S.IdServicio, 
            D.Descripcion, 
            D.PrecioServicio
        FROM @Detalleservicio D
        INNER JOIN SERVICIO S ON D.Descripcion = S.Descripcion;

        COMMIT TRANSACTION registro
		SET @Mensaje = 'Venta registrada exitosamente.';
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registro
    END CATCH
END
GO

--------------------REPORTES------------------------------------------------------------------

create PROC sp_ReporteCompras(
 @fechainicio varchar(10),
 @fechafin varchar(10),
 @idproveedor int
 )
 as
 begin
 SET DATEFORMAT dmy;  
 select 
convert(char(10),dv.FechaRegistro,103)[FechaRegistro],pr.RazonSocial,p.Descripcion,dv.Cantidad,dv.PrecioCompra,dv.MontoTotal from COMPRA c
inner join PRODUCTO p on p.IdProducto = c.IdCompra
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
inner join DETALLE_COMPRA dv on dv.IdCompra = c.IdCompra
 where CONVERT(date,dv.FechaRegistro) between @fechainicio  and @fechafin
 and pr.IdProveedor = iif(@idproveedor=0,pr.IdProveedor,@idproveedor)
end
go


 ------------ventas-----------------

create PROC sp_ReporteVentas(
 @fechainicio varchar(10),
 @fechafin varchar(10)
 )
 as
 begin
 SET DATEFORMAT dmy;  
 select 
 convert(char(10),d.FechaRegistro,103)[FechaRegistro],u.Descripcion,d.Cantidad,d.PrecioVenta,d.SubTotal from DETALLE_VENTA d
inner join PRODUCTO u on u.IdProducto = d.IdProducto
 where CONVERT(date,d.FechaRegistro) between @fechainicio and @fechafin
end
go


---------------------SERVICIO----------------------

create PROC sp_ReporteServicios(
 @fechainicio varchar(10),
 @fechafin varchar(10)
 )
 as
 begin
 SET DATEFORMAT dmy;  
 select 
 convert(char(10),v.FechaRegistro,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumento,v.MontoTotal,
 v.Ruc,v.Placa,v.NombreCliente,
 p.Descripcion[Descripcion],dv.PrecioServicio[SubTotal]
 from VENTA_SERVICIO v
 inner join DETALLE_SERVICIO dv on dv.IdVentaServicio = v.IdVentaServicio
 inner join SERVICIO p on p.IdServicio = dv.IdDetalleServicio
 where CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
end

GO

----------------------------------------------

-------------------------COTIZACION---------------------

create TYPE [dbo].[EDETALLE_COTIZACION] AS TABLE (
    [IdProducto] INT NULL,
	[PrecioVenta] DECIMAL(18,2) NULL,
    [Cantidad] INT NULL,
    [SubTotal] DECIMAL(18,2) NULL
)
GO

CREATE PROCEDURE usp_RegistrarCotizacion (
    @TipoDocumento varchar(500),
    @NombreCliente varchar(500),
    @Placa varchar(100),
	@Descripcion varchar(400),
    @MontoTotal decimal(18,2),
    @DetalleVenta [EDETALLE_COTIZACION] READONLY,
    @Resultado bit OUTPUT,
    @Mensaje varchar(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @idcotizacion int = 0;
        SET @Resultado = 1;
        SET @Mensaje = '';

        BEGIN TRANSACTION registro;

        -- Inserta en la tabla VENTA, referenciando al IdCliente existente o recién creado
        INSERT INTO COTIZACION(TipoDocumento, NombreCliente, Placa, MontoTotal,Descripcion)
        VALUES(@TipoDocumento , @NombreCliente, @Placa, @MontoTotal, @Descripcion)

        -- Obtiene el ID de la venta recién ;insertada
        SET @idcotizacion = SCOPE_IDENTITY();

        -- Inserta en la tabla DETALLE_VENTA, incluyendo Kilometraje y Descripcion
        INSERT INTO DETALLE_COTIZACION (IdCotizacion, IdProducto,PrecioVenta, Cantidad, SubTotal)
		SELECT @idcotizacion, IdProducto, PrecioVenta, Cantidad, SubTotal
		FROM @DetalleVenta;

        COMMIT TRANSACTION registro
		SET @Mensaje = 'Venta registrada exitosamente.';
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registro
    END CATCH
END
GO

---------------------------SERserCOTI 
create TYPE [dbo].[ADETALLE_SERCOTIZACION] AS TABLE (
    [Descripcion] Varchar(500),
	[PrecioServicio] DECIMAL(18,2) NULL
)
GO

create PROCEDURE usp_RegistrarSEERCotizacion (
    @TipoDocumento varchar(500),
    @NombreCliente varchar(500),
    @Placa varchar(100),
	@DetalleDescripcion varchar(400),
    @MontoTotal decimal(18,2),
    @Detalleservicio [ADETALLE_SERCOTIZACION] READONLY,
    @Resultado bit OUTPUT,
    @Mensaje varchar(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @idcotizacion int = 0;
        SET @Resultado = 1;
        SET @Mensaje = '';

        BEGIN TRANSACTION registroq;

        -- Inserta en la tabla VENTA, referenciando al IdCliente existente o recién creado
        INSERT INTO SERCOTIZACION(TipoDocumento, NombreCliente, Placa, MontoTotal,DetalleDescripcion)
        VALUES(@TipoDocumento , @NombreCliente, @Placa, @MontoTotal, @DetalleDescripcion)

        -- Obtiene el ID de la venta recién ;insertada
        -- Obtiene el ID de la venta recién ;insertada
        SET @idcotizacion = SCOPE_IDENTITY();

		INSERT INTO SERVICIO (Descripcion)
        SELECT DISTINCT Descripcion
        FROM @Detalleservicio
        WHERE Descripcion NOT IN (SELECT Descripcion FROM SERVICIO);

         -- Paso 3: Insertar en DETALLE_VENTA, vinculando IdServicio desde la tabla SERVICIO
        INSERT INTO DETALLE_SERCOTIZACION(IdCotizacion, IdServicio, Descripcion, PrecioServicio)
        SELECT 
            @idcotizacion, 
            S.IdServicio, 
            D.Descripcion, 
            D.PrecioServicio
        FROM @Detalleservicio D
        INNER JOIN SERVICIO S ON D.Descripcion = S.Descripcion;

		COMMIT TRANSACTION registroq
		SET @Mensaje = 'Venta registrada exitosamente.';
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registroq
    END CATCH
END
GO

create PROCEDURE CargarProductos
    @Codigo varchar(25),
    @Descripcion varchar(500),
    @Categoria varchar(50), -- Ahora recibimos la descripción de la categoría
    @Ubicacion varchar(100),
    @Stock int,
    @PrecioCompra decimal(10, 2),
    @PrecioVenta decimal(10, 2),
    @UnidadMedida varchar(10),
    @FechaRegistro varchar(25),
    @Resultado bit OUTPUT,
    @Mensaje varchar(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION; -- Inicia una transacción para asegurar consistencia

        -- Variable para almacenar el IdCategoria
        DECLARE @IdCategoria int;

        -- Verifica si la categoría ya existe
        SELECT @IdCategoria = IdCategoria 
        FROM CATEGORIA 
        WHERE Descripcion = @Categoria;

        -- Si la categoría no existe, la inserta y obtiene su Id
        IF @IdCategoria IS NULL
        BEGIN
            INSERT INTO CATEGORIA (Descripcion, Estado)
            VALUES (@Categoria, 1);

            SET @IdCategoria = SCOPE_IDENTITY();
        END

        -- Inserta el producto usando el IdCategoria
        INSERT INTO PRODUCTO (
            Codigo, Descripcion, IdCategoria, Ubicacion, Stock, PrecioCompra, PrecioVenta, UnidadMedida, FechaRegistro
        )
        VALUES (
            @Codigo, @Descripcion, @IdCategoria, @Ubicacion, @Stock, @PrecioCompra, @PrecioVenta, @UnidadMedida, @FechaRegistro
        );

        -- Si todo es exitoso, confirmamos la transacción
        COMMIT TRANSACTION;

        SET @Resultado = 1;
        SET @Mensaje = 'Producto y categoría (si fue necesario) registrados correctamente.';
    END TRY
    BEGIN CATCH
        -- En caso de error, hacemos rollback y enviamos el mensaje de error
        ROLLBACK TRANSACTION;

        SET @Resultado = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END;
GO

---------------------------------------------------------------------


 insert into rol (Descripcion)
 values('ADMINISTRADOR')

 GO

  insert into rol (Descripcion)
 values('EMPLEADO')

 GO

  insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('101010','ADMIN','@GMAIL.COM','123',1,1)

 GO

  insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('2020','EMPLEADO','@GMAIL.COM','456',2,1)

 GO


 insert into PERMISO(IdRol,NombreMenu)values
(1,'menuusuario'),
(1,'menumantenedor'),
(1,'menuventas'),
(1,'menucompras'),
(1,'menuclientes'),
(1,'menuproveedor'),
(1,'menureportes'),
(1,'menuacercade')
GO
insert into PERMISO(IdRol,NombreMenu)values
(2,'menumantenedor'),
(2,'menuventas'),
(2,'menucompras'),
(2,'menuclientes'),
(2,'menuproveedor'),
(2,'menureportes')
GO

insert into NEGOCIO(IdNegocio,Nombre,RUC,Direccion,Logo) values
(1,'Luka Automortriz','20202020','av.123',null)

