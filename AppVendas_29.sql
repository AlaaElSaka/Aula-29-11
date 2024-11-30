create database Store;
go

use Store;

create table Vendas (
Id  int identity primary key ,
Produto nvarchar (100) ,
Descricao nvarchar (max),
DataVenda date ,
Valor decimal (18,2)
);

