use monstarlab;
create table full_year(
	id bigint primary key not null auto_increment,
    newspaper varchar(20),
    subscriber varchar(20)
);
create table half_year(
	id bigint primary key not null auto_increment,
    newspaper varchar(30),
    subscriber varchar(50)
);

insert into full_year (newspaper,subscriber)
values
('The Paragon Herald','Crissy Sepe'),
('The Daily Reporter','Tonie Moreton'),
('Morningtide Daily','Erwin Chitty'),
('Daily Breakfast','Tonie Moreton'),
('Independent Weekly','Lavelle Phu');

insert into half_year (newspaper,subscriber)
values
('The Daily Reporter','Lavelle Phu'),
('Daily Breakfast','Tonie Moreton'),
('The Paragon Herald','Lia Cover'),
('The Community Gazette','Lavelle Phu'),
('Nova Daily','Lia Cover'),
('Nova Daily','Joya Buss');
select * from half_year ;
select * from full_year ;
SELECT subscriber FROM full_year
WHERE newspaper LIKE '%Daily%'
UNION
SELECT subscriber FROM half_year
WHERE newspaper LIKE '%Daily%'
ORDER BY subscriber ASC;