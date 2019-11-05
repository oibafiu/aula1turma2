create table Usuarios 
(
Id int primary key Identity(1,1),
Nome nchar(100) not null,
Login nchar(50) not null,
Senha nchar(50) not null

)

create table Carros 
(
Id int primary key Identity(1,1),
Modelo nchar(50) not null,
Marca nchar(50) not null,
Placa nchar(7),
Ano int 
)

create table Locacoes
(
Id int primary key Identity(1,1),
UsuarioId int,
CarroId int,
Valor money,
DataInicial datetime,
DataDevolucao datetime
)

Create table ControleUsuarios
(
Ativo bit default 1,
UsuarioCriacao int,
UsuarioAlteracao int,
DataCriacao DateTime,
DataAlteracao datetime
)