insert into Funcionarios 
(Nome) values ('Felipe'), ('Giomar')

Insert into Produtos (Nome, Valor) values ('Skol beats',5.49),('Budweiser',6.99),
('Stella Artois',3.49),('Patagonia Pilsener', 15.90),('Corona Extra',4.99)

Select * From Funcionarios
Select * From Pedidos 

Insert into Pedidos (FuncionarioId, ProdutoId, Quantidade) values (1,3,3), (1,1,2),
(2,5,5)

select * from funcionarios Order by Nome

select ped.Id, fun.Nome from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id

select fun.Nome, 
SUM(ped.Quantidade) as 'Quantidade' from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id 
Group by fun.Nome


Select fun.Nome, Sum(ped.Quantidade * pro.Valor) as 'Total' from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
inner join Produtos pro on ped.ProdutoId = pro.Id
Group by fun.Nome

select top 1 pro.Nome, SUM(ped.Quantidade) as 'Quantidade' from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId 
Group by pro.Nome
order by sum(ped.Quantidade) desc 


select top 1 pro.Nome, SUM(ped.Quantidade * pro.Valor) as 'Receita total' 
from Produtos pro inner join
Pedidos ped on pro.Id = ped.ProdutoId group by pro.Nome order by 'Receita total'

select * from Funcionarios fun inner join Pedidos ped on fun.Id = ped.FuncionarioId inner join
Produtos pro on ped.ProdutoId = pro.Id

select * from Produtos pro left join Pedidos ped on pro.Id = ped.ProdutoId where ped.ProdutoId is null

select * from produtos where id not in (select ped.ProdutoId from funcionarios fun inner join Pedidos ped on fun.Id 
= ped.FuncionarioId where fun.Nome like 'Felipe%')

select pro.Nome, Count(ped.ProdutoId) as 'Quantidade' from Produtos pro left join Pedidos ped on pro.Id = ped.ProdutoId group by
pro.Nome order by 'Quantidade' desc