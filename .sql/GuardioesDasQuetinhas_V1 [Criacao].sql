use GuardioesDasQuentinhas;

create table Usuario(
	[Id] bigint not null primary key,
	[UsuarioType] nvarchar(20) not null,
	[Nome] nvarchar(100) not null,
	[Senha] nvarchar(20) not null,
	[Email] nvarchar(50) not null,
	[IsDeleted] bool not null
)

create table Cliente(
	[Id] bigint not null primary key foreign key references Usuario(Id)
)

create table Vendedor(
	[Id] bigint not null primary key Foreign key references Usuario(Id)
)

create table Cartao(
	[Id] int not null primary key,
	[Bandeira] nvarchar(30) not null,
	[CodSeg] int not null,
	[NomeTitular] nvarchar(100) not null,
	[NumeroCartao] nvarchar(20) not null,
	[Validade] Date not null,
	[IsDeleted] bool not null,
	[ClienteId] bigint not null foreign key references Cliente(Id)

)

create table Loja (
	[Id] int not null primary key,
	[Nome] nvarchar(50) not null,
	[EnderecoDaLoja] nvarchar(10) not null,
	[IsDeleted] bool not null,
	[MediaAvaliacoes] float not null,
	[VendedorId] bigint not null foreign key references Vendedor(Id)
)

create table Pedido(
	[Id] bigint not null primary key,
	[Comentario] nvarchar(500),
	[Preco] smallmoney not null,
	[IsDeleted] bool not null,
	[ClienteId] bigint not null foreign key references Cliente(Id),
	[LojaId] int not null foreign key references Loja(Id),
	[PagamentoId] bigint foreign key references Pagamento(Id),
	[Preco] smallmoney not null 
)

create table Porcao(
	[Id] bigint primary key,
	[Item] nvarchar(30) not null,
	[Preco] smallmoney not null,
	[Quantidade] int not null,
	[IsDeleted] bool not null,
	[PratoId] int not null foreign key references Prato(Id),
)

create table Prato(
	[Id] int primary key,
	[Preco] smallmoney not null,
	[IsDeleted] bool not null,
	[LojaId] int not null foreign key references Loja(Id),
	[PedidoId] bigint not null foreign key references Pedido(Id)
)


create table Avaliacao(
	[Id] int not null primary key,
	[Nota] int not null,
	[Comentario] nvarchar(500),
	[DataAvaliacao] DateTime not null,
	[PedidoId] int not null foreign key references Pedido(Id),
)


create table Pagamento(
	[Id] bigint not null primary key,
	[OpcaoPagamento] nvarchar(20) not null,
	[PedidoId] bigint not null foreign key references Pedido(Id)
)

create table PratoPorcao(
	[Id] bigint primary key,
	[PratoId] int not null foreign key references Prato(Id),
	[PorcaoId] bigint not null foreign key references Porcao(Id),
	constraint cts_prato_porcao unique (PratoId, PorcaoID) 
)


create table AreaEntregaLoja (
	[Id] bigint primary key,
	[CEP] nvarchar(10) not null,
	[LojaId] int not null foreign key references Loja(Id)
)
