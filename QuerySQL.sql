use master
go

if exists(select * from sys.databases where name = 'McDataBase')
	drop database McDataBase

create database leilao
go

use McDataBase
go