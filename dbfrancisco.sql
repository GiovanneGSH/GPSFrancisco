drop database dbFrancisco;
 
create database dbFrancisco;
 
use dbFrancisco;
 
create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(12) not null,
primary key(codUsu));
 
insert into tbUsuarios(nome,senha)
	values('senac','senac');
 
select * from tbUsuarios;