CREATE database FriendsOfHumans;
use FriendsOfhumans;
create table Animals (
id INT auto_increment primary key,
name varchar(255),
type varchar(255),
birth_date date);

create table PetAnimals (
id INT auto_increment primary key,
name varchar(255),
type enum('Dog','Cat','Hamster'),
birth_date date);

create table PackAnimals (
id INT auto_increment primary key,
name varchar(255),
type enum('Horse','Camel','Donkey'),
birth_date date);

insert into PetAnimals (name,type,birh_date) values
('max','Horse','2024-00-20'),
('Bella','Camel','2025-11-10');

delete from PacklAnimals where type = 'Camel';
create table HorsesAndDonkeys As select * from PackAnimals where type in ('Horse','Donkey');

create table YoungAnimals as select*, timestampdiff(Year,brith_date,Curdate()) between 1 and 3;

create table AllAnimals as select 'pet' as category, * from Pet animals Union select 'Pack' as category,* from PackAnimals;