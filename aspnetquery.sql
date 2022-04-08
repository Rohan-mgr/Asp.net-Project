create database Employee;

use Employee;

create table empDetails(
	eid int primary key identity(100, 1),
	ename varchar(20) not null, 
	eaddress varchar(30), 
	contacts bigint
);

create table teachers(
	tid int primary key identity(300, 1),
	tname varchar(20) not null, 
	taddress varchar(30), 
	contacts bigint
);
select * from teachers;

drop table teachers;
insert into empDetails(ename, eaddress, contacts) values ('Rohan', 'simara', 9807654321);
insert into empDetails(ename, eaddress, contacts) values ('Roshan', 'kathmandu', 1234556765);

insert into teachers(tname, taddress, contacts) values ('Rohan', 'simara', 9807654321);
insert into teachers(tname, taddress, contacts) values ('Prashna', 'Kandaghari', 9807666321);
insert into teachers(tname, taddress, contacts) values ('kando', 'nayabasti', 9807666321);




select * from empDetails;
select * from students;
select * from teachers;

create table employee_salary_details(
	id int primary key identity(20000,1), 
	employee_id int, 
	salary_paid decimal(18,2), 
	paid_date datetime,
	foreign key (employee_id) references empDetails(eid)
);

create table teacher_salary(
	id int primary key identity(30000,1), 
	tid int, 
	salary_paid decimal(18,2), 
	paid_date datetime,
	foreign key (tid) references teachers(tid)
);
drop table employee_salary_details;

select * from employee_salary_details;
insert into employee_salary_details(employee_id, salary_paid, paid_date) values (101, 1564.3, '2022-02-12');
insert into teacher_salary(tid, salary_paid, paid_date) values (300, 1564.3, '2022-02-12');
select * from teacher_salary;
