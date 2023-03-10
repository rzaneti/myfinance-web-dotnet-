CREATE DATABASE myfinance
use myfinance

create table planoconta(
id int identity(1,1) not null,
descricao varchar(50) not null,
tipo char(1) not null,
primary key (id)
);

create table transacao(
id int identity(1,1) not null,
data datetime not null,
valor decimal(9,2),
historico text,
planocontaid int not null,
primary key(id),
foreign key(planocontaid) references planoconta(id)
);



