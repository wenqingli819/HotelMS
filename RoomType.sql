use [Wenqing.HotelDB]

SET IDENTITY_INSERT [dbo].[RoomType] ON 

insert into RoomType (Id, RTDesc, Rent) values (1, 'Standard', 1000);
insert into RoomType (Id, RTDesc, Rent) values (2, 'Deluxe', 1500);
insert into RoomType (Id, RTDesc, Rent) values (3, 'Suite', 2000);

SET IDENTITY_INSERT [dbo].[RoomType] OFF