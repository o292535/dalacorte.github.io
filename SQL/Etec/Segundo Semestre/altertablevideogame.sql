alter table funcionario add check(upper(sexo) = 'm' or upper(sexo) = 'f');
alter table funcionario modify sexo char(10);

alter table pessoa modify cpf_pessoa char(11) unique not null;

alter table jogos modify nome_jogo varchar(200) not null;