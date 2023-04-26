create database country;
use country;

create table countries(country_id int not null primary key, cname varchar(30));
exec sp_help countries;
insert into countries values(1,'India'),(2,'Australia'),(3,'USA'),(4,'China'),(5,'Russia');

create table states(state_id int not null primary key,state_name varchar(30),country_id int, constraint fk_country_id foreign key(country_id)
references countries(country_id));
insert into states values(10,'Maharashtra',1),(20,'Queensland',2),(30,'California',3),(40,'Sinchuan',4),(50,'Serbia',5);
select * from states;

create table city(city_id int primary key,Cityname varchar(20),state_id int, constraint fk_state foreign key(state_id) references states(state_id));
insert into city values(101,'Mumbai',10),(102,'Sydney',20),(103,'NewYork',30),(104,'Beijing',40),(105,'Moscow',50);
select * from city;

--1)Write query to find country name for the state of Maharashtra
    select c.cname from countries c join states s on c.country_id=s.country_id where state_name='Maharashtra';

--2)Write query to find all states from India
     select state_name from states s join countries c on s.country_id=c.country_id where c.cname='India';

--3)Write query to find out all the city names from the California and Serbia states
     select c.Cityname from city c join states s on c.state_id=s.state_id where s.state_name='California'or s.state_name='Serbia';

--4)Find out state in which one city is present
    select c.Cityname from city c join states s on c.state_id=s.state_id where s.state_name='Queensland';

--5)Find out countrywise state count
   
--6)Find out all states names which end with 'K' character
	
