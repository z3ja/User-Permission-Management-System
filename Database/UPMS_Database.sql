create database UPMS;
go
use UPMS;
go
create table title_tb
(
	title_name varchar(50)
)
go
create table role_tb
(
	rid int primary key identity(1000,1),
	role_name varchar(10) not null
)
go
create table user_tb
(
	[uid] int primary key identity(1000,1),
	[role_id] int,
	username Varchar(50) not null,
	[password] varchar(255) not null,
	is_active bit not null
	CONSTRAINT FK_user_tb_role_tb FOREIGN KEY (role_id)
    REFERENCES role_tb(rid)
)
go
create table permission_tb
(
	pid int primary key identity(1000,1),
	[role_id] int,
	button1 bit null,
	button2 bit null,
	button3 bit null,
	button4 bit null,
	button5 bit null
	CONSTRAINT FK_permission_tb_role_tb FOREIGN KEY (role_id)
    REFERENCES role_tb(rid)
)
GO
select * from role_tb;
GO
select * from user_tb;
GO
select * from permission_tb;
GO
insert into title_tb values ('User Permission Management system')
GO
insert into role_tb (role_name) 
values ('Admin');
GO
insert into user_tb (role_id,username,password,is_active) 
values (1000,'Admin','admin',1);
GO
insert into permission_tb (role_id,button1,button2,button3,button4,button5) values (1000, 1, 1, 1, 1, 1);