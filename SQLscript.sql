create database musicappDB

use musicappDB
/*
-Pjesma objekat treba da ima sljedeæe atribute: naziv pjesme, naziv izvoðaèa, url link za pjesmu,
ocjena pjesme(od 1 do 5), da li je pjesma favorit, datum unosa pjesme u aplikaciju, datum
posljednjeg editovanja pjesme u aplikaciji, kategoriju
- Kategorija je odvojena klasa koja ima naziv kategorije
*/

create table song 
(
	song_id int identity, 
	song_name nvarchar(50),
	song_artist nvarchar(50),
	song_url nvarchar(255),
	song_rating int,
	is_favourite varchar(50),
	created_date datetime default getdate(),
	edited_date datetime default getdate(),
	category_id int,
	constraint pk_song primary key (song_id),
	constraint fk_song_category foreign key (category_id) references category (category_id)
)

create table category 
(
	category_id int identity,
	category_name varchar(50),
	constraint pk_category primary key (category_id)
)  


insert into category values ('Narodna')
insert into category values ('Zabavna')
insert into category values ('Pop')
insert into category values ('Rock')
insert into category values ('Turbo folk')
insert into category values ('Hip hop')
insert into category values ('Punk')
insert into category values ('Jazz')

select * from category