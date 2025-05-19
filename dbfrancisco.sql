drop database dbFrancisco;
 
create database dbFrancisco;
 
use dbFrancisco;
 
create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(12) not null,
primary key(codUsu));
 
insert into tbUsuarios(nome,senha)values('senac','senac');
 
select * from tbUsuarios;

update tbUsuarios set nome='senac',senha='111111111111' where codUsu = 1;


-- pesquisa filtrada por código

select * from tbUsuarios where codUsu = 1;

-- pesquisa filtrada por nome

select * from tbUsuarios where nome like '%" + usuarios + "%';