create database hotel_management

use hotel_management

create table users
(
	id int primary key identity(1,1),
	username varchar(30) NULL,
	password varchar(30) NULL,
	role varchar(30) NULL,
	date_register date NULL
);

select * from users;

use hotel_management
insert into users (username, password,role)
values ('admin','admin','admin')

SELECT COUNT(*) FROM users 
WHERE username = 'admin' AND password = 'admin';

insert into users (username, password,role)
values ('nour','12345','user')

delete from users where id = 3 or id = 4 or id = 5 or id = 6;

select * from users;
