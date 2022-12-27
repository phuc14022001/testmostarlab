use monstarlab;
create table suspect (
	id bigint primary key not null,
    name varchar(20) not null,
    surname varchar(20)not null,
    height float not null,
    weight float
);
insert into suspect values
(1,'John','Doe',165,60),
(2,'Bill','Green',170,67),
(3,'Baelfire','Grehn',172,70),
(4,'Bill','Gretan',165,55),
(5,'Brendon','Grewn',150,50),
(6,'bill','Green',169,50);

select id,name,surname from suspect
where height <=170 and name like 'b%' and  surname like 'Gre_n';