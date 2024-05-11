/*criando o banco de dados */
create database pizzaria1;

/*usando o banco de dados */
use pizzaria1;
/*criando as tabelas do banco de dados */

create table tblogin(
 codigo int primary key auto_increment,
 usuario varchar(50) not null,
 senha varchar(50) not null
);
create  table tbfuncionario(
 codFunc int primary key auto_increment,
 nome varchar(50),
 usuario varchar(50),
 senha varchar(50)
);


create table tbcliente(
codCli int primary key auto_increment,
nome varchar(50) not null,
email varchar(50) not null,
telefone varchar(20) not null
);

create table tbpedido(
codPedido int primary key auto_increment,
tipoPizza varchar(50),
valorPizza varchar(50),
valorOpcao varchar(50),
valorTotal varchar(50)
);
/*inserindo dados banco*/
insert into tblogin(usuario,senha)values("Admin","1234567");

/*consultando tabelas banco de dados */
select * from tblogin;
select * from tbcliente;
select * from tbfuncionario;
select * from tbpedido;





