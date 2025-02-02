create database DemoAuthen
go
use DemoAuthen
go

create table [User](
	[UserId] varchar(50) primary key,
	[UserName] nvarchar(100) not null,
	[UserEmail] nvarchar(255) not null,
	[UserImage] nvarchar(300) not null,
	[UserToken] nvarchar(max) null,
	[UserAge] int null
)
go
create table [Role](
	[RoleId] int identity(1,1) primary key,
	[RoleName] nvarchar(50) not null
)
go
create table [UserRole](
	[UserId] varchar(50) not null,
	[RoleId] int not null,
	primary key([UserId],[RoleId])
)
go

Update [User] set UserName=N'Tai Phan',UserToken=N'eyJhbGciOiJSUzI1NiIsImtpZCI6IjBiMGJmMTg2NzQzNDcxYTFlZGNhYzMwNjBkMTI1NmY5ZTQwNTBiYTgiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJhY2NvdW50cy5nb29nbGUuY29tIiwiYXpwIjoiNDA3NTc2NjIwMTQ3LWNiZHM1MXJnMjR0dDJoMWdzc2IwM2ZnYjVpYnZ0Nzk3LmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwiYXVkIjoiNDA3NTc2NjIwMTQ3LWNiZHM1MXJnMjR0dDJoMWdzc2IwM2ZnYjVpYnZ0Nzk3LmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwic3ViIjoiMTAzMDA4OTMwNDc4NzY3MzIyOTY5IiwiZW1haWwiOiJwaGFudGFudGFpOTgwMEBnbWFpbC5jb20iLCJlbWFpbF92ZXJpZmllZCI6dHJ1ZSwiYXRfaGFzaCI6Ikotdy1VRU5IMjRYbXdkSHhhWWlYcVEiLCJuYW1lIjoiVGFpIFBoYW4iLCJwaWN0dXJlIjoiaHR0cHM6Ly9saDUuZ29vZ2xldXNlcmNvbnRlbnQuY29tLy1PVWhOWVVIOXBONC9BQUFBQUFBQUFBSS9BQUFBQUFBQUFBQS9BQ0hpM3JkdU9fMDFmQURhMlBUcDNjeWpqZ3ZxdTBmcFV3L3M5Ni1jL3Bob3RvLmpwZyIsImdpdmVuX25hbWUiOiJUYWkiLCJmYW1pbHlfbmFtZSI6IlBoYW4iLCJsb2NhbGUiOiJlbiIsImlhdCI6MTU2OTIxMDg5MywiZXhwIjoxNTY5MjE0NDkzLCJqdGkiOiIxZjMxYjg3MTU3NzNjYzlmMzMxNTc1ZGMzNTUyMzNlNjk4OWU2MWNjIn0.MTarIRCexgbV6I1T5V7ss_LFxW7ir4Pmu3vjbfOiQqvsKBg2sCTCyykndCoLChozC70vxlHcTxxDhIri-nI8OLDCM8HY3cKm5gtxN1eT-atQ2aHGFMbDwRG5BAiHDVKyz8PlAAlcQopUU3MyD3hO1LfReoKidLl3p0-OBdGZnOXlWoHUgO5NxFuYSu-ieJImn-qAq1_Br45d41naHTY6nfYk4XHrRb6Qg3pxHEhvz30JJlUfP5ELW9eal-GagD4Hfx5ZuE9tl__EsKTgJVARtRQ2eao9fFDYH-620PtOxxvA85sgBTCKOimWp4N9IhAxJQwgba31ZCB_HPykHnHbwg',UserImage=N'https://lh5.googleusercontent.com/-OUhNYUH9pN4/AAAAAAAAAAI/AAAAAAAAAAA/ACHi3rduO_01fADa2PTp3cyjjgvqu0fpUw/s96-c/photo.jpg'