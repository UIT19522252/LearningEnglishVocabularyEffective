create database Data
go
use Data
create table USERINFOR
(
	id int primary key,
	userName varchar(100),
	hashPassword varchar(100)
)
select * from USERINFOR
--drop database Data