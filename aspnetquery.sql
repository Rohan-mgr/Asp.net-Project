create database Employee;

use Employee;

create table empDetails(
	eid int primary key identity(100, 1),
	ename varchar(20) not null, 
	eaddress varchar(30), 
	contacts bigint
);
create table students(
	sid int primary key identity(200, 1),
	sname varchar(20) not null, 
	saddress varchar(30), 
	contacts bigint
);
drop table students;
create table teachers(
	tid int primary key identity(300, 1),
	tname varchar(20) not null, 
	taddress varchar(30), 
	contacts bigint
);

drop table teachers;
insert into empDetails(ename, eaddress, contacts) values ('Rohan', 'simara', 9807654321);
insert into empDetails(ename, eaddress, contacts) values ('Roshan', 'kathmandu', 1234556765);
insert into students(sname, saddress, contacts) values ('Rohan', 'simara', 9807654321);
insert into students(sname, saddress, contacts) values ('Prashna', 'Kandaghari', 9807666321);
insert into students(sname, saddress, contacts) values ('kando', 'nayabasti', 9807666321);

insert into teachers(tname, taddress, contacts) values ('Rohan', 'simara', 9807654321);
insert into teachers(tname, taddress, contacts) values ('Prashna', 'Kandaghari', 9807666321);
insert into teachers(tname, taddress, contacts) values ('kando', 'nayabasti', 9807666321);

select * from empDetails;
select * from students;
select * from teachers;