use [Wenqing.HotelDB]

--TRUNCATE TABLE [dbo].[Customer];

SET IDENTITY_INSERT [dbo].[Customer] ON 

insert into Customer (Id, CName, Address, Phone, Email) values (1, 'Margi Nassau', '4 Mariners Cove Pass', '633-191-4725', 'mnassau0@php.net');
insert into Customer (Id, CName, Address, Phone, Email) values (2, 'Sheeree Worsham', '74000 Morningstar Lane', '123-665-0212', 'sworsham1@webs.com');
insert into Customer (Id, CName, Address, Phone, Email) values (3, 'Dinny Grocock', '30723 Rusk Drive', '756-204-8876', 'dgrocock2@godaddy.com');
insert into Customer (Id, CName, Address, Phone, Email) values (4, 'Lisette Mathivon', '27370 Alpine Road', '250-139-6022', 'lmathivon3@paypal.com');
insert into Customer (Id, CName, Address, Phone, Email) values (5, 'Yorke Natwick', '2864 International Hill', '672-827-2612', 'ynatwick4@princeton.edu');
insert into Customer (Id, CName, Address, Phone, Email) values (6, 'Mareah Leonida', '9804 Fuller Court', '536-452-7700', 'mleonida5@pagesperso-orange.fr');
insert into Customer (Id, CName, Address, Phone, Email) values (7, 'Kiele Murton', '50 Buhler Street', '197-538-8937', 'kmurton6@boston.com');
insert into Customer (Id, CName, Address, Phone, Email) values (8, 'Ailee Brinsford', '16753 Forest Dale Circle', '243-720-6408', 'abrinsford7@usatoday.com');
insert into Customer (Id, CName, Address, Phone, Email) values (9, 'Tucker Letteresse', '6 Mitchell Crossing', '608-664-9587', 'tletteresse8@europa.eu');
insert into Customer (Id, CName, Address, Phone, Email) values (10, 'Oswell Lohan', '7046 Gina Point', '962-188-5533', 'olohan9@google.de');

SET IDENTITY_INSERT [dbo].[Customer] OFF