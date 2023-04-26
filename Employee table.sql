create table employees(eid int,ename varchar(20),salary int,city varchar(10),gender varchar(20),dept_name varchar(10));

exec sp_help employees;

select * from employees;

insert into employees values(101,'Priya',70000,'Pune','Female','Sales'),(102,'Amit',50000,'Nagar','Male','Hr'),
(103,'Riya',86000,'Nashik','Female','sale'),(104,'Ram',90000,'Pune','Male','Admin'),(105,'Nikhil',70000,'Pune','Male','Hr');

 insert into employees values(106,'Nayan',65000,'Mumbai','male','Sales');

 insert into employees values(104,'Ram',90000,'Pune','Male','Admin');

--find employees who got salary more than 60000 and she/he is from Mumbai lacation

select * from employees where salary>60000 and city='Mumbai';

--find employees from pune location

select * from employees where city='Pune';

--delete employee who is working in Admin department

delete from employees where dept_name='Admin';

--find all employees who are working in Hr dept

select * from employees where dept_name='Hr';

--find out all the female employees working in sales dept

select * from employees where dept_name='Sales';

--Find out all male employees whose salary is less than 60000

select * from employees where salary<60000;
