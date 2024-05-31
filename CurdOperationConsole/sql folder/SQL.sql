Create table SuperMarketShope
(
 ShopId int not null  Identity (1,1), 
 Name nvarchar (100)  not null, 
 OwnerName nvarchar (100) not null,
 NumberOfProduct int not null,
 ContactNumber bigint not null,
 Emailid nvarchar (100) not null,
 Location nvarchar (100) not null
)

select *from SuperMarketShope

