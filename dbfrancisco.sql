-- drop database dbFrancisco;
 
create database dbFrancisco;
 
use dbFrancisco;

-- criando a tabela usuários
 
create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(12) not null,
primary key(codUsu));


-- insert into tbUsuarios(nome,senha)values('senac','senac');
-- insert into tbUsuarios(nome,senha)values('admin','admin');


-- criando a tabela atribuições

create table tbAtribuicoes(
codAtr int not null auto_increment,
nome varchar(100) not null,
primary key(codAtr));

--insert into tbAtribuicoes(nome)values(nome);

-- select * from tbAtribuicoes order by nome; // ordem alfabética

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
data datetime,
hora datetime,
status int(1),
primary key(codVol),
foreign key(codAtr)references tbAtribuicoes(codAtr));


create table tbFotos(
codFotos int not null auto_increment,
nome varchar(100),
campo_imagem longBlob,
primary key(codFotos));


create table tbUnidades(
codUnid int not null auto_increment,
descricao varchar(50),
unidade char(2),
primary key(codUnid));




-- insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status)values(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status);

 
-- insert into tbUsuarios(nome,senha)values('senac','senac');
 
-- select * from tbUsuarios;

-- update tbUsuarios set nome='senac',senha='111111111111' where codUsu = 1;


-- -- pesquisa filtrada por código

-- select * from tbUsuarios where codUsu = 1;

-- -- pesquisa filtrada por nome

-- select * from tbUsuarios where nome like '%" + usuarios + "%';

-- select * from tbUsuarios where nome = 'senac';


-- SELECT * FROM tbvoluntarios WHERE codVol = codVol;" busca voluntário por código


--SELECT * FROM tbvoluntarios WHERE @nome like '%@nome%'; busca voluntário por nome

--select * from tbVoluntarios where nome = @nome;


--Inserir imagem no banco de dados

-- insert into tbfotos(nome, campo_imagem)values(@nome,@campo_imagem);


-- select func.nome as 'Nome do Funcionario',usu.nome as 'Nome do Usuario' from tbUsuarios as usu inner join tbFuncionarios as func on usu.codfunc = func.codfunc where func.nome like '%i%';


-- INNER JOIN

-- SELECT *, atr.nome FROM tbVoluntarios AS vol INNER JOIN tbAtribuicoes AS atr ON vol.codAtr = atr.codAtr WHERE vol.nome = 'nome';

-- DELETE

-- DELETE FROM tbVoluntarios WHERE codVol = @codVol;