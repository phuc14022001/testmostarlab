use monstarlab;

create table expressions(
	id int not null,
    a int not null,
    b int not null,
    operation char(5) not null,
    c int
);
insert into expressions values
(1,2,3,'+',5),
(2,2,3,'+',6),
(3,3,2,'/',1),
(4,4,7,'*',28),
(5,54,2,'-',27),
(6,3,0,'/',0);

select * from expressions
where operation = '+' and a+b=c
or operation = '-' and a-b=c
or operation = '*' and a*b=c
or operation = '/' and a/b=c