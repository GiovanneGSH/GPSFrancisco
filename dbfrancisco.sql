-- drop database dbFrancisco;
 
create database dbFrancisco;
 
use dbFrancisco;

-- criando a tabela usuários
 
create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(12) not null,
primary key(codUsu));


<<<<<<< HEAD
-- insert into tbUsuarios(nome,senha)values('senac','senac');
-- insert into tbUsuarios(nome,senha)values('admin','admin');


=======
>>>>>>> 591f0fed1aebd9c6102131aadfd2a7f47c2f2884
-- criando a tabela atribuições

create table tbAtribuicoes(
codAtr int not null auto_increment,
nome varchar(100) not null,
primary key(codAtr));

--insert into tbAtribuicoes(nome)values(nome);

select * from tbAtribuicoes order by nome;

-- criando a tabela voluntários

create table tbVoluntarios(
codVol int not null auto_increment,
nome varchar(100) not null,
email varchar(100),
telCel char(15),
endereco varchar(100),
numero char(5),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
codAtr int not null,
data date,
<<<<<<< HEAD
hora time,
=======
hora int,
>>>>>>> 591f0fed1aebd9c6102131aadfd2a7f47c2f2884
status int(1),
primary key(codVol),
foreign key(codAtr)references tbAtribuicoes(codAtr));

-- insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status)values(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status);

 
-- insert into tbUsuarios(nome,senha)values('senac','senac');
 
-- select * from tbUsuarios;

-- update tbUsuarios set nome='senac',senha='111111111111' where codUsu = 1;


-- -- pesquisa filtrada por código

-- select * from tbUsuarios where codUsu = 1;

-- -- pesquisa filtrada por nome

-- select * from tbUsuarios where nome like '%" + usuarios + "%';

-- select * from tbUsuarios where nome = 'senac';

