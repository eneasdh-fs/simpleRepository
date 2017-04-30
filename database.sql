
use master
GO

create database usable;
GO

use usable;
GO

create table districts(
	id			char(6)			not null	primary key,
	name		varchar(50)		not null
);
GO


create table students(
	id			integer			not null	primary key identity,
	first_name	varchar(60)		not null,
	last_name	varchar(60)		not null,
	full_name	varchar(120)	not null,
	email		varchar(60)		not null	unique,
	district_id	char(6)			not null	constraint fk_users_distric foreign key references districts(id)
);
GO

INSERT [dbo].[districts] ([id], [name]) VALUES (N'150101', N'Lima')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150102', N'Ancón')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150103', N'Ate')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150104', N'Barranco')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150105', N'Breña')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150106', N'Carabayllo')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150107', N'Chaclacayo')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150108', N'Chorrillos')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150109', N'Cieneguilla')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150110', N'Comas')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150111', N'El Agustino')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150112', N'Independencia')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150113', N'Jesús María')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150114', N'La Molina')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150115', N'La Victoria')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150116', N'Lince')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150117', N'Los Olivos')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150118', N'Lurigancho')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150119', N'Lurin')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150120', N'Magdalena del Mar')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150121', N'Pueblo Libre')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150122', N'Miraflores')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150123', N'Pachacamac')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150124', N'Pucusana')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150125', N'Puente Piedra')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150126', N'Punta Hermosa')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150127', N'Punta Negra')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150128', N'Rímac')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150129', N'San Bartolo')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150130', N'San Borja')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150131', N'San Isidro')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150132', N'San Juan de Lurigancho')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150133', N'San Juan de Miraflores')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150134', N'San Luis')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150135', N'San Martín de Porres')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150136', N'San Miguel')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150137', N'Santa Anita')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150138', N'Santa María del Mar')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150139', N'Santa Rosa')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150140', N'Santiago de Surco')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150141', N'Surquillo')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150142', N'Villa El Salvador')
INSERT [dbo].[districts] ([id], [name]) VALUES (N'150143', N'Villa María del Triunfo')

