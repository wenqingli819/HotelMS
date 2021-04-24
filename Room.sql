use [Wenqing.HotelDB]

SET IDENTITY_INSERT [dbo].[RoomType] ON 

insert into Room (Id, Status, RoomTypeId) values (10043, 'True', 1);
insert into Room (Id, Status, RoomTypeId) values (1004, 'False', 2);
insert into Room (Id, Status, RoomTypeId) values (1408, 'True', 3);
insert into Room (Id, Status, RoomTypeId) values (1109, 'True', 2);
insert into Room (Id, Status, RoomTypeId) values (1709, 'True', 1);

SET IDENTITY_INSERT [dbo].[RoomType] OFF