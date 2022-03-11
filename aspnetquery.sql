create database Employee;
use Employee;

create table empDetails(
	eid int primary key,
	ename varchar(20) not null, 
	eaddress varchar(30), 
	contacts int
);
drop table empDetails;
insert into empDetails values (1, 'Rohan', 'simara', 1234556765);
select * from empDetails;