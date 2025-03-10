create database Policy_Management
use Policy_Management


create table Policies (
PolicyID int identity(1,1) primary key,
PolicyHolderName varchar(30) not null,
PolicyType int not null,
StartDate date not null,
EndDate date not null
)

select * from Policies
truncate table Policies