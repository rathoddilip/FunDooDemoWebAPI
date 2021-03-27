USE FunDooNotesDB;

create table UserTable
(
ID int not null identity(100,1) primary key,
FirstName varchar(150) not null,
LastName varchar (150) not null,
EmailId varchar(100) not null,
Password varchar(250) not null,
StartDate date not null,
ModifiedDate date not null,
);

select * from UserTable;

insert into UserTable(FirstName,LastName,EmailId,Password,StartDate,ModifiedDate) values
('Dilip','Rathod', 'dilip@gmail.com','Pass@123','2021-03-23','2021-03-23'),
('Sandip','Chavan', 'Sandip@gmail.com','Pass@123','2020-03-23','2021-02-23');

update UserTable set EmailId='sandip@gmail.com' where ID=101;

alter table UserTable
add UserName varchar(100);

update UserTable set UserName='dilip' where ID=100;
update UserTable set UserName='sandip' where ID=101;