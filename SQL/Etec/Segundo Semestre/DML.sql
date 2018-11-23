insert into tipolocal(descricao_tipolocal) values('Residencial');
insert into tipolocal(descricao_tipolocal) values('Comercial');
insert into tipolocal(descricao_tipolocal) values('Pessoal');

select * from tipolocal;

insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('Snoopy', 'Jogo de ação com cachorro, fases', 'Ação', 'Top Games Kis');
insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('Super Mario', '', 'Ação', 'Top Games Kis');
insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('Copa do Mundo 2010 - Africa do Sul', 'Competição futebolística', 'Ação', 'Top Games Kis');
insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('FIFA', 'Simulação do EA Sports', 'Futebol', 'Top Games Kis');
insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('Homem Aranha', 'Versão TEEN', 'Ação', 'Top Games Kis');
insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('LestsLearn', 'Jogos para praticar inglês', 'Educativo', 'Top Games Kis');
insert into jogos(nome_jogo, descricao_jogo, genero_jogo, produtora_jogo) values('Capitão América', '', 'Ação', 'Top Games Kis');

select * from jogos;

insert into videogame(modelo_videogame,ns_videogame) values('XBOX360','XB91054125');
insert into videogame(modelo_videogame,ns_videogame) values('Playstation 3 Slim','SO85E689');
insert into videogame(modelo_videogame,ns_videogame) values('Sony PSP','SOF582189');
insert into videogame(modelo_videogame,ns_videogame) values('Sony PS Vita','SOG782290');
insert into videogame(modelo_videogame,ns_videogame) values('Playstation 2 Slim','SO5A09999');
insert into videogame(modelo_videogame,ns_videogame) values('Nintendo Wii','NINFF0051486');

select * from videogame;
insert into tipopessoa(descricao_tipopessoa) value ('Cliente');
insert into tipopessoa(descricao_tipopessoa) value ('Funcionario');


insert into pessoa(tipopessoa_idtipopessoa,nome_pessoa,rg_pessoa,cpf_pessoa) values ('1','Victor Dalacorte','1457955-8','11297520944');
insert into pessoa(tipopessoa_idtipopessoa,nome_pessoa,rg_pessoa,cpf_pessoa) values ('2','Giomar de Oliveira','2657945-8','26597520944');
insert into pessoa(tipopessoa_idtipopessoa,nome_pessoa,rg_pessoa,cpf_pessoa) values ('1','Bruno Correia','3978453-9','39874548407');
insert into pessoa(tipopessoa_idtipopessoa,nome_pessoa,rg_pessoa,cpf_pessoa) values ('2','Jonathan Almeida','3979459-9','39874528407');
insert into pessoa(tipopessoa_idtipopessoa,nome_pessoa,rg_pessoa,cpf_pessoa) values ('1','Ricardo Lopes','4587457-1','29874587915');


select * from pessoa;

insert into cliente(pessoa_idpessoa,pai_cliente,mae_cliente,nick_cliente,senha_cliente) values ('3','','','bcorrea','159874');
insert into cliente(pessoa_idpessoa,pai_cliente,mae_cliente,nick_cliente,senha_cliente) values ('4','','','jalmeida','854789');


select * from cliente;

insert into funcionario(pessoa_idpessoa,sexo,idade) values ('1','M','22');
insert into funcionario(pessoa_idpessoa,sexo,idade) values ('2','M','22');
insert into funcionario(pessoa_idpessoa,sexo,idade) values ('5','F','19');

select * from funcionario;

insert into contato(tipolocal_idtipolocal,pessoa_idpessoa,telefone_contato,mail_contato) values ('3','1','1156662008','aaraujo@ig.com.br');
insert into contato(tipolocal_idtipolocal,pessoa_idpessoa,telefone_contato,mail_contato) values ('1','1','1156691587','alearaujo@uol.com.br');
insert into contato(tipolocal_idtipolocal,pessoa_idpessoa,telefone_contato,mail_contato) values ('3','2','1156698877','goliveira@terra.com.br');
insert into contato(tipolocal_idtipolocal,pessoa_idpessoa,telefone_contato,mail_contato) values ('3','3','11998770028','bcorrea@ig.com.br');
insert into contato(tipolocal_idtipolocal,pessoa_idpessoa,telefone_contato,mail_contato) values ('3','4','11998887900','jalmeida@bol.com.br');
insert into contato(tipolocal_idtipolocal,pessoa_idpessoa,telefone_contato,mail_contato) values ('3','5','1156637895','rlopes@hotmail.com.br');

select * from contato;

insert into endereco(tipolocal_idtipolocal,pessoa_idpessoa,logradouro_endereco,numero_endereco,complemente_endereco,bairro_endereco,cep_endereco,cidade_endereco,estado_endereco) values ('3','1','Rua Demonte Risco','220','','Interlagos','04814-578','São Paulo','SP');
insert into endereco(tipolocal_idtipolocal,pessoa_idpessoa,logradouro_endereco,numero_endereco,complemente_endereco,bairro_endereco,cep_endereco,cidade_endereco,estado_endereco) values ('3','2','Rua Nascimento de Moraes','51','','Grajaú','04922-510','São Paulo','SP');
insert into endereco(tipolocal_idtipolocal,pessoa_idpessoa,logradouro_endereco,numero_endereco,complemente_endereco,bairro_endereco,cep_endereco,cidade_endereco,estado_endereco) values ('3','3','Praça Montes Claros','15','A','Progresso','04914-000','São Paulo','SP');
insert into endereco(tipolocal_idtipolocal,pessoa_idpessoa,logradouro_endereco,numero_endereco,complemente_endereco,bairro_endereco,cep_endereco,cidade_endereco,estado_endereco) values ('3','4','Av. Primavera','1010','','Primavera','04010-100','São Paulo','SP');
insert into endereco(tipolocal_idtipolocal,pessoa_idpessoa,logradouro_endereco,numero_endereco,complemente_endereco,bairro_endereco,cep_endereco,cidade_endereco,estado_endereco) values ('3','5','Rua Marinez','2','','Orion','04878-879','São Paulo','SP');

select * from endereco;

insert into aluguel(funcionario_idfuncionario,videogame_idvideogame,cliente_idcliente,jogos_idjogos,valor_alugel,date_aluguel) values ('3','6','1','3','17.86','2004-01-20');
insert into aluguel(funcionario_idfuncionario,videogame_idvideogame,cliente_idcliente,jogos_idjogos,valor_alugel,date_aluguel) values ('3','6','1','3','17.86','2013-09-01');
insert into aluguel(funcionario_idfuncionario,videogame_idvideogame,cliente_idcliente,jogos_idjogos,valor_alugel,date_aluguel) values ('3','6','1','3','17.86','2013-01-04');
insert into aluguel(funcionario_idfuncionario,videogame_idvideogame,cliente_idcliente,jogos_idjogos,valor_alugel,date_aluguel) values ('1','1','2','1','19.5','2013-03-03');

select * from aluguel;