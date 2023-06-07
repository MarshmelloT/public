use master
--创建数据库Test数据库
create database Test
go
--连接到Test
use Test
--创建类型表ProjectType
go
create table ProjectType
(
	ID int identity(1,1) primary key,--表主键
	[Name] varchar(50) not null
)
--创建工程表
go
create table Bidding
(
	ID int identity(1,1) primary key,--主键
	ProName varchar(50) not null,
	ProTypeID int not null,
	ProAddress varchar(200)  null,
	Input varchar(20)  null,
	[Date] datetime not null,
	Charge varchar(20) not null,
	Unit varchar(100)  null,
	Amount money not null,
	Contacts varchar(20) null,
	Tel varchar(20) null,
)

insert into ProjectType ([Name]) values('电力')
insert into ProjectType ([Name]) values('水利')
insert into ProjectType ([Name]) values('通信')
insert into ProjectType ([Name]) values('路桥')
insert into ProjectType ([Name]) values('空调安装')



insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('青海洪湖护养项目1',1,'青海洪湖养护院','马晓','2013-2-3','马晓','建设单位一建',100000,'龙虾','15865845569')

insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('某某路段建设',2,'青海洪湖养护院','马晓','2013-2-3','马晓','建设单位一建',100000,'龙虾','15865845569')

insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('云南水库建设3',3,'青海洪湖养护院','马晓','2013-2-3','马晓','建设单位一建',100000,'龙虾','15865845569')

insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('西乡塘区马路维修4',4,'青海洪湖养护院','马晓','2013-2-3','马晓','建设单位一建',100000,'龙虾','15865845569')


--忽略类型的ID链表查
--select b.*,p.[Name] as ProTypeName from Bidding as b left join ProjectType as p on b.ProTypeID=p.ID

--链表带条件
--select b.*,p.[Name] as ProTypeName from Bidding as b left join ProjectType as p on b.ProTypeID=p.ID where b.ProName like '%%' and b.ProTypeID=2

--select * from ProjectType



