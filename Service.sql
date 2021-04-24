use [Wenqing.HotelDB]

--TRUNCATE TABLE [dbo].[Service];

SET IDENTITY_INSERT [dbo].[Service] ON 

insert into Service (Id, SDesc, Amount, ServiceDate, RoomId, CustomerId, Advance, BookingDays, CheckIn, TotalPersons) values (9001, 'standard', 12000, '9/9/2020', 1004,1, 4000.00, 8,'9/14/2020',2);
insert into Service (Id, SDesc, Amount, ServiceDate, RoomId, CustomerId, Advance, BookingDays, CheckIn, TotalPersons) values (9002, 'standard', 2000, '7/13/2020', 1709,2, 1000.00, 2, '7/13/2020',1);
insert into Service (Id, SDesc, Amount, ServiceDate, RoomId, CustomerId, Advance, BookingDays, CheckIn, TotalPersons) values (9003, 'standard', 8000, '3/24/2020', 1408,3, 3000.00, 4,'4/24/2020',3);
insert into Service (Id, SDesc, Amount, ServiceDate, RoomId, CustomerId, Advance, BookingDays, CheckIn, TotalPersons) values (9004, 'standard', 4500, '7/16/2020', 1109,4, 1500.00, 3,'7/17/2020',2);

SET IDENTITY_INSERT [dbo].[Service] OFF