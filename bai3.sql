use monstarlab;

create table users1(
	ID bigint primary key not null auto_increment,
	Name varchar(50) not null,
    score int 
);
insert into users1(Name, score)
values
('gongy',3001),
('urandom',2401),
('eduardische',2477),
('Gassa',2999),
('bcc32',2658),
('Alex_2oo8',6000),
('mirosuaf',2479),
('Sparik',2399),
('thomas_holmes',2478),
('cthaeghya',2400);

select Name from (select NAME, row_number() over(order by score desc) as rownum from users1 ) as users1
where rownum between 4 and 8
