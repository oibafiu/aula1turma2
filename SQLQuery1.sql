create table Funcionarios

(
Id int primary key identity(1,1),
Nome nvarchar(50) not null, 
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()

)

create table Produtos

(
Id int primary key identity(1,1),
Nome nvarchar(50) not null, 
Valor money not null,
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()

)

create table Pedidos

(
Id int primary key identity(1,1),
FuncionarioId int not null,
ProdutoId int not null,
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate(),
Constraint [FK_Pedidos_To_Funcionarios]
Foreign Key ([FuncionarioId]) references [Funcionarios]([Id]),
Constraint [Fk_Pedidos_To_Produtos] Foreign Key ([ProdutoId]) references [Produtos]([Id])

)

Alter table Pedidos
Add Quantidade int not null

