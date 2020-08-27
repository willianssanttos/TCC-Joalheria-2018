create table faturas
(
nfaturas int not null primary key,
data date not null,
cliente varchar(15) not null,
codigo varchar(15) not null,
descricao varchar(30) not null,
quantidade int not null,
preco decimal(18,2) not null,
subtotal decimal(18,2) not null,
sub decimal(18,2) not null,
taxa decimal(18,2) not null,
desconto decimal(18,2) not null,
total decimal(18,2) not null,
)