create database Employee;
use Employee;

create table empDetails(
	eid int primary key identity(100, 1),
	ename varchar(20) not null, 
	eaddress varchar(30), 
	contacts bigint
);
create table students(
	sid int primary key,
	sname varchar(20) not null, 
	saddress varchar(30), 
	contacts bigint
);
drop table empDetails;
insert into empDetails(ename, eaddress, contacts) values ('Rohan', 'simara', 9807654321);
insert into empDetails(ename, eaddress, contacts) values ('Roshan', 'kathmandu', 1234556765);
insert into students values (1, 'Rohan', 'simara', 9807654321);
insert into students values (2, 'Prashna', 'Kandaghari', 9807666321);
insert into students values (3, 'kando', 'nayabasti', 9807666321);
select * from empDetails;
select * from students;