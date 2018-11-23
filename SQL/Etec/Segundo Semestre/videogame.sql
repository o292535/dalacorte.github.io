drop database videogame;
create database videogame;
use videogame;

create table tipolocal(idtipolocal int primary key not null auto_increment,
descricao_tipolocal varchar(30));

create table tipopessoa (idtipopessoa int primary key not null auto_increment,
descricao_tipopessoa varchar(20));

create table jogos (idjogos int primary key not null auto_increment,
nome_jogo varchar(300) not null,
descricao_jogo varchar(120) not null,
genero_jogo varchar(20) not null,
produtora_jogo varchar(40) not null);

create table videogame (idvideogame int primary key not null auto_increment,
modelo_videogame varchar(20) not null,
ns_videogame varchar(24) not null);

create table pessoa (idpessoa int primary key not null auto_increment,
tipopessoa_idtipopessoa int,
nome_pessoa varchar(80) not null,
rg_pessoa varchar(9) unique not null,
cpf_pessoa char(14) unique not null,
foreign key(tipopessoa_idtipopessoa) references tipopessoa(idtipopessoa));

create table endereco (idendereco int primary key not null auto_increment, 
tipolocal_idtipolocal int, 
pessoa_idpessoa int,
logradouro_endereco varchar(70) not null,
numero_endereco varchar(70) not null,
complemente_endereco varchar(100),
bairro_endereco varchar(70) not null,
cep_endereco varchar(9) not null, 
cidade_endereco varchar(30) not null,
estado_endereco char(2) not null,
foreign key(tipolocal_idtipolocal) references tipolocal(idtipolocal),
foreign key(pessoa_idpessoa) references pessoa(idpessoa));

create table cliente (idcliente int primary key not null auto_increment,
pessoa_idpessoa int not null,
pai_cliente varchar(80) not null,
mae_cliente varchar(80) not null,
nick_cliente varchar(12) not null,
senha_cliente varchar(8) not null,
foreign key(pessoa_idpessoa) references pessoa(idpessoa));

create table funcionario (idfuncionario int primary key not null auto_increment,
pessoa_idpessoa int,
sexo char(1) check(upper(sexo) = 'm' or upper(sexo) = 'f'),
idade int,
foreign key(pessoa_idpessoa) references pessoa(idpessoa));

create table aluguel (idalugel int primary key not null auto_increment,
funcionario_idfuncionario int,
videogame_idvideogame int,
cliente_idcliente int,
jogos_idjogos int,
valor_alugel int,
date_aluguel date,
foreign key(funcionario_idfuncionario) references funcionario(idfuncionario),
foreign key(videogame_idvideogame) references videogame(idvideogame),
foreign key(cliente_idcliente) references cliente(idcliente),
foreign key(jogos_idjogos) references jogos(idjogos));

create table contato (idcontato int primary key auto_increment,
tipolocal_idtipolocal int,
pessoa_idpessoa int,
telefone_contato varchar(13),
mail_contato varchar(30),
foreign key(tipolocal_idtipolocal) references tipolocal(idtipolocal),
foreign key(pessoa_idpessoa) references pessoa(idpessoa));

