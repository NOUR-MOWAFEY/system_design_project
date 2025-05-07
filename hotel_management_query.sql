/*Create The Database*/
create database hotel_management

/*Use The DataBase And Create Users Table*/
use hotel_management
create table users
(
	id int primary key identity(1,1),
	username varchar(30) NULL,
	password varchar(30) NULL,
	role varchar(30) NULL,
	date_register DATETIME DEFAULT GETDATE(),
);

/*Use The DataBase And Insert First User*/
use hotel_management
insert into users (username, password,role)
values ('admin','admin','admin')

/*Use The DataBase And Create Rooms Table*/
use hotel_management;
CREATE TABLE rooms
(
	room_id INT PRIMARY KEY IDENTITY(1,1),
	room_name VARCHAR(25) NOT NULL UNIQUE,
    room_beds_no INT NOT NULL,
    room_view VARCHAR(25) NOT NULL,
    room_size VARCHAR(25) NOT NULL,
	room_price FLOAT NOT NULL,
	room_available_from DATE NULL,
);

/*Use The DataBase And Create Customers Table*/
USE hotel_management;
CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	client_id VARCHAR(25) NOT NULL,
	full_name VARCHAR(50) NOT NULL,
	phone_no VARCHAR(25) NOT NULL,
	address VARCHAR(50) NOT NULL,
	dob DATE NOT NULL,
	gender VARCHAR(10)  NULL,
	date_from DATE  NULL,
	date_to DATE  NULL,
	room_name VARCHAR(25) NULL,
);

/*Use The DataBase And Insert Rooms Data*/
USE hotel_management;
INSERT INTO rooms (room_name, room_beds_no, room_view, room_size, room_price, room_available_from) VALUES
('Deluxe King', 1, 'Sea', 'Suite', 2500, NULL),
('Family Suite', 2, 'Mountain', 'Suite', 3500, NULL),
('Standard Twin', 2, 'City', 'Standard Room', 1500, NULL),
('Single Room', 1, 'Garden', 'Standard Room', 1000, NULL),
('Luxury Suite', 1, 'Ocean', 'Suite', 5000, NULL),
('Executive Suite', 1, 'City Center', 'Suite', 4000, NULL),
('Double Room', 2, 'Pool', 'Standard Room', 2000, NULL),
('Penthouse Suite', 3, 'Panoramic', 'Suite', 7500, NULL),
('Budget Room', 1, 'No View', 'Budget Room', 700, NULL),
('Presidential Suite', 1, 'Skyline', 'Suite', 10000, NULL);

/*Use The DataBase And Insert Customers Data*/
USE hotel_management;
INSERT INTO customers (client_id, full_name, phone_no, address, dob, gender, date_from, date_to, room_name)
VALUES
('1234567890123456', 'Ahmed Mohamed', '01095332145', 'Cairo, Egypt', '1985-08-15', 'Male', '2024-12-10', '2024-12-15', 'Deluxe King'),
('2345678901234567', 'Sara Ahmed', '01095332146', 'Alexandria, Egypt', '1990-03-22', 'Female', '2024-12-12', '2024-12-14', 'Standard Twin'),
('3456789012345678', 'Mohamed Ali', '01095332147', 'Giza, Egypt', '1982-07-30', 'Male', '2024-12-20', '2024-12-25', 'Executive Suite'),
('4567890123456789', 'Mona Youssef', '01095332148', 'Sharm El Sheikh, Egypt', '1995-11-05', 'Female', '2024-12-15', '2024-12-17', 'Family Room'),
('5678901234567890', 'Tarek Hussein', '01095332149', 'Hurghada, Egypt', '1978-06-18', 'Male', '2024-12-08', '2024-12-12', 'Economy Single'),
('6789012345678901', 'Dalia Fathi', '01095332150', 'Cairo, Egypt', '1987-02-10', 'Female', '2024-12-18', '2024-12-22', 'Presidential Suite'),
('7890123456789012', 'Omar Taha', '01095332151', 'Luxor, Egypt', '1992-09-25', 'Male', '2024-12-09', '2024-12-13', 'Double Deluxe'),
('8901234567890123', 'Nourhan Adel', '01095332152', 'Port Said, Egypt', '2000-01-17', 'Female', '2024-12-11', '2024-12-14', 'Junior Suite');

/*To See The Data In The Tables*/
select * from customers;
select * from rooms;
select * from users;

/* !!!TO DELETE THE TABLES!!! */
DROP TABLE users;
DROP TABLE rooms;
DROP TABLE customers;
