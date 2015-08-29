create database HotelUkraine;
go

use HotelUkraine;
go
-- create table
create table tblTypeRooms
(
	Id int not null identity(1,1),
	Name nvarchar(255) not null,
	Quantity int not null,
	constraint PK_TypeRooms_Id primary key (Id)
)
go
create table tblDescriptionRoom
(
	Id int not null identity(1,1),
	TypeRoomId int not null,
	Price int not null,
	[Description] nvarchar(1024) not null,
	Includes nvarchar(1024) not null,
	constraint PK_DescriptionRoom_Id primary key (Id)
)
go
create table tblBrokedRoom
(
	Id int not null identity(1,1),
	Fio nvarchar(100) not null,
	NumberPhone nvarchar(25) null,
	Email nvarchar(25) null,
	DescriptionRoomId int not null,
	DateFrom date not null,
	DateTo date not null,
	Reserve int not null,
	constraint PK_BrokedRoom_Id primary key (Id)
)
go
create proc procBrokedRoom
	@Fio nvarchar(100),
	@NumberPhone nvarchar(25),
	@Email nvarchar(25),
	@DescriptionRoomId int,
	@DateFrom Date,
	@DateTo Date,
	@Reserve int

as

begin
	INSERT INTO [dbo].[tblBrokedRoom]
           ([Fio]
           ,[NumberPhone]
           ,[Email]
           ,[DescriptionRoomId]
           ,[DateFrom]
           ,[DateTo]
           ,[Reserve])
     VALUES
           (@Fio
           ,@NumberPhone
           ,@Email
           ,@DescriptionRoomId
           ,@DateFrom
           ,@DateTo
           ,@Reserve)
end;

