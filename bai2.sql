use monstarlab;

create table monstarlab.Product(
	Id int primary key not null auto_increment,
    name varchar(50)not null,
    price int not null,
    quanity int 
	);

insert into Product (name, price, quanity)
values 
('Tomato',10,4),
('Cucumber',8,5),
('Red People',20,2),
('Feta',40,1);

select * from Product;
select name From Product
where (price * quanity) = (select MAX(price * quanity) from Product)
ORDER BY name ASC
LIMIT 1;