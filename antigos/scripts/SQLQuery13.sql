Update Livros set Ativo = 0 where Id = 4
go
select * from Livros order by id desc OFFSET 1 rows fetch next 1 rows only