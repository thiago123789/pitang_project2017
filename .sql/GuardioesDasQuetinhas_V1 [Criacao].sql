use GuardioesDasQuentinhas;

create table Usuario (
	[Id] bigint not null primary key identity(0,1),
	[UsuarioType] nvarchar(20) null,
	[Nome] nvarchar(100) not null,
	[Senha] nvarchar(20) not null,
	[Email] nvarchar(50) not null,
	[IsDeleted] tinyint not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null
)

create table Cartao(
	[Id] int not null primary key identity(0,1),
	[Bandeira] nvarchar(30) not null,
	[CodSeg] int not null,
	[NomeTitular] nvarchar(100) not null,
	[NumeroCartao] nvarchar(20) not null,
	[Validade] Date not null,
	[IsDeleted] tinyint not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null,
	[ClienteId] bigint not null foreign key references Usuario(Id)
)

create table Loja (
	[Id] int not null primary key identity(0,1),
	[Nome] nvarchar(50) not null,
	[EnderecoDaLoja] nvarchar(10) not null,
	[IsDeleted] tinyint not null,
	[MediaAvaliacoes] float not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null,
	[VendedorId] bigint not null foreign key references Usuario(Id)
)

create table PermissaoUsuario (
	[UsuarioId] bigint not null, 
	[PermissaoId] int not null,
	CONSTRAINT PK_Permissao_Usuario UNIQUE (UsuarioId, PermissaoId)  
)

create table Permissao (
	[Id] int not null primary key identity(0,1),
	[Papel] nvarchar(20) not null unique
)	

create table Pagamento(
	[Id] bigint not null primary key identity(0,1),
	[OpcaoPagamento] nvarchar(20) not  null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null
)

create table Pedido(
	[Id] bigint not null primary key identity(0,1),
	[Comentario] nvarchar(500),
	[Preco] smallmoney not null,
	[IsDeleted] tinyint not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null,
	[ClienteId] bigint not null foreign key references Cliente(Id),
	[LojaId] int not null foreign key references Loja(Id),
	[PagamentoId] bigint null foreign key references Pagamento(Id) 
)


create table Prato(
	[Id] int primary key identity(0,1),
	[Preco] smallmoney not null,
	[IsDeleted] tinyint not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null,
	[LojaId] int not null foreign key references Loja(Id),
	[PedidoId] bigint not null foreign key references Pedido(Id)
)

create table Porcao(
	[Id] bigint primary key identity(0,1),
	[Item] nvarchar(30) not null,
	[Preco] smallmoney not null,
	[Quantidade] int not null,
	[IsDeleted] tinyint not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null,
	[PratoId] int not null foreign key references Prato(Id),
)

create table Avaliacao(
	[Id] int not null primary key identity(0,1),
	[Nota] int not null,
	[Comentario] nvarchar(500),
	[DataAvaliacao] DateTime not null,
	[DataCriacao] DateTime2 null,
	[UltimaModificacao] DateTime2 null,
	[PedidoId] bigint not null foreign key references Pedido(Id),
)

create table PratoPorcao(
	[Id] bigint primary key identity(0,1),
	[PratoId] int not null foreign key references Prato(Id),
	[PorcaoId] bigint not null foreign key references Porcao(Id),
	constraint cts_prato_porcao unique (PratoId, PorcaoID) 
)

create table AreaEntregaLoja (
	[Id] bigint primary key identity(0,1),
	[Bairro] nvarchar(10) not null,
	[LojaId] int not null foreign key references Loja(Id)
)

-- ALTER TABLE Pagamento NOCHECK CONSTRAINT ALL;
-- ALTER TABLE Pagamento ADD PedidoId bigint not null foreign key references Pedido(Id);
-- ALTER TABLE Pagamento WITH CHECK CHECK CONSTRAINT all;
