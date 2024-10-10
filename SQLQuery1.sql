create database CourseManagementSystem;
create table Courses(
   CourseId INT IDENTITY(1,1) PRIMARY KEY ,
   Title NVARCHAR(50) NOT NULL,
   Duration NVARCHAR(50) NOT NULL,
   Price DECIMAL NOT NULL);

insert into Courses(Title,Duration,price)
values('Java','6 months',1.00);

select * from Courses;