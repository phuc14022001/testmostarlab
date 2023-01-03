create database monstarlab;
use monstarlab;
-- bai1
create table monstarlab.users (
	Id int not null,
    userName varchar(30) not null,
    role varchar(30) not null,
    email varchar(30)
    );
    
insert into users (Id, userName, role, email)
values
(6,'fasalytch','premium','much.premium@role.com'),
(13,'luckygirl','regular','fun@meh.com'),
(16,'todayhumor','guru','today@humor.com'),
(23,'Felix','admin','felix@codefights.com'),
(52,'admin666','AdmiN','iamtheadmin@admin.admin'),
(87,'solver100500','regular','email@notbot.com');
select email from users 
where not role = 'admin' and not role = 'premium' 
order by email asc;



