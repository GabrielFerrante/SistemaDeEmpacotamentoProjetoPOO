create database projetoPOO;

GO
create table produtos 
(
	PRid int not null PRIMARY KEY IDENTITY,
	PRnome varchar(80) not null,
	PRpeso int not null,
	PRlargura int not null,
	PRaltura int not null,
	PRprofundidade int not null,
	PRquantidade int
);
GO
create procedure salvarProduto (
	@PRnome as varchar(80),
	@PRpeso as int,
	@PRlargura as int,
	@PRaltura as int,
	@PRprofundidade int,
	@UsuarioLogado as int,
	@PRquantidade as int
)
as
begin tran
	declare @auxERROR as int
	insert into produtos
	values (@PRnome,  @PRpeso, @PRlargura, @PRaltura, @PRprofundidade,@PRquantidade);
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

	insert into logs values ('Cadastro de produto: '+@PRnome,GETDATE(),@UsuarioLogado)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end
COMMIT TRAN

GO
create procedure alterarProduto 
(
	@PRid as int,
	@PRnome as varchar(80),
	@PRpeso as int,
	@PRlargura as int,
	@PRaltura as int,
	@PRprofundidade int,
	@UsuarioLogado as int,
	@PRquantidade as int
)
as
begin tran
	declare @auxERROR as int
	update produtos
	set PRnome = @PRnome,
		PRpeso = @PRpeso,
		PRlargura = @PRlargura,
		PRaltura = @PRaltura,
		PRprofundidade = @PRprofundidade,
		PRquantidade = @PRquantidade
	where PRid = @PRid
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

	insert into logs values ('Alteração do produto: '+@PRnome,GETDATE(),@UsuarioLogado)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end
commit tran



GO

--TABELA PACOTES

create table materiais
(
	MAid int not null PRIMARY KEY IDENTITY,
	nome varchar(30) not null
)
GO
insert into materiais values ('Madeira')
insert into materiais values ('Papelão')
insert into materiais values ('Papel')
insert into materiais values ('Vidro')
insert into materiais values ('Alumínio')
insert into materiais values ('Plástico')
insert into materiais values ('Isopor')
insert into materiais values ('Papel-cartão')
insert into materiais values ('Polietileno')
insert into materiais values ('Folha de Alumínio')
GO
create table pacotes
(
	PAid int not null PRIMARY KEY IDENTITY,
	PAtipo varchar(120) not null,
	PAquantidade int not null,
	PAlargura int not null,
	PAaltura int not null,
	PAprofundidade int not null,
	PApeso int not null,
	MAid int not null,
	CONSTRAINT MAid FOREIGN KEY (MAid) REFERENCES materiais (MAid)

);
GO
create procedure salvarPacote
(
	@PAtipo as varchar(120),
	@PAquantidade as int,
	@PAlargura as int,
	@PAaltura as int,
	@PAprofundidade as int,
	@PApeso as int,
	@MAmaterial as int,
	@UsuarioLogado as int
	 
)
as
begin tran
	declare @auxERROR int
	INSERT INTO pacotes 
	values (@PAtipo,@PAquantidade,@PAlargura,@PAaltura,@PAprofundidade,@PApeso,@MAmaterial)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end
	declare @PAid as int
	SET @PAid = (select MAX(PAid) from pacotes)
	insert into logs values ('Cadastro de pacote: '+@PAtipo,GETDATE(),@UsuarioLogado)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end
commit tran

GO
create procedure alterarPacote
(
	@PAid as int,
	@PAtipo as varchar(120),
	@PAquantidade as int,
	@PAlargura as int,
	@PAaltura as int,
	@PAprofundidade as int,
	@PApeso as int,
	@MAmaterial as int,
	@UsuarioLogado as int

)
as
begin tran
	declare @auxERROR int
	update pacotes
	set 
		PAtipo = @PAtipo,
		PAquantidade = @PAquantidade,
		PAlargura = @PAlargura,
		PAaltura = @PAaltura,
		PAprofundidade = @PAprofundidade,
		PApeso = @PApeso,
		MAid = @MAmaterial
	where PAid = @PAid

	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

	insert into logs values ('Atualização de pacote: '+@PAtipo,GETDATE(),@UsuarioLogado)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

commit tran

GO
--Usuarios

create table usuarios(
	USid int not null PRIMARY KEY IDENTITY,
	USnome varchar(120) not null,
	USlogin varchar(30) not null,
	USsenha varchar(12) not null,
	Cargo varchar(30) not null,
	
);
GO
insert into usuarios values ('Admin','Admin','123','Administrador')

GO
create procedure salvarUsuario
(	
	@USnome as varchar(120),
	@USlogin as varchar(30),
	@USsenha as varchar(12),
	@Cargo as varchar(30),
	@USid as int
)
as
begin tran
	declare @auxERROR int
	insert into usuarios
	values( 
		@USnome,
		@USlogin,
		@USsenha,
		@Cargo)

	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

	
	insert into logs values ('Cadastro de usuário: '+@USnome,GETDATE(),@USid)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

commit tran

GO
create procedure alterarUsuario
(	
	@USid as int,
	@USnome as varchar(120),
	@USlogin as varchar(30),
	@USsenha as varchar(12),
	@Cargo as varchar(30),
	@UserLogado as int
)
as
begin tran
	declare @auxERROR int
	UPDATE usuarios
	set
		USnome = @USnome,
		USlogin = @USlogin,
		USsenha = @USsenha,
		Cargo = @Cargo
	where @USid = USid;

	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

	insert into logs values ('Alteração de usuário: '+@USnome, GETDATE(),@UserLogado)
	SELECT @auxERROR = @@ERROR
	if(@auxERROR <> 0)begin
		rollback tran
	end

commit tran



GO
create table logs
(
	LOid int not null PRIMARY KEY IDENTITY,
	LOoperacao varchar(60) not null ,
	LOdata datetime not null,
	USid int not null,
	CONSTRAINT USid FOREIGN KEY (USid) REFERENCES usuarios (USid)
)

