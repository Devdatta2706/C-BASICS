create table Department1(did int,ename varchar(20),salary int,primary key(did));
sp_help Department1; 
insert into Department1 values(101,'Admin',50000);
select * from Department1;
insert into Department1 values(100,'Sales',20000);

create table Emp(eid int,ename varchar(20),esub varchar(20));
sp_help ;
alter table Emp add constraint dept primary key(eid);
alter table Emp drop column eid;
alter table Emp add eid int not null;



