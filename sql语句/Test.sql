use master
--�������ݿ�Test���ݿ�
create database Test
go
--���ӵ�Test
use Test
--�������ͱ�ProjectType
go
create table ProjectType
(
	ID int identity(1,1) primary key,--������
	[Name] varchar(50) not null
)
--�������̱�
go
create table Bidding
(
	ID int identity(1,1) primary key,--����
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

insert into ProjectType ([Name]) values('����')
insert into ProjectType ([Name]) values('ˮ��')
insert into ProjectType ([Name]) values('ͨ��')
insert into ProjectType ([Name]) values('·��')
insert into ProjectType ([Name]) values('�յ���װ')



insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('�ຣ���������Ŀ1',1,'�ຣ�������Ժ','����','2013-2-3','����','���赥λһ��',100000,'��Ϻ','15865845569')

insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('ĳĳ·�ν���',2,'�ຣ�������Ժ','����','2013-2-3','����','���赥λһ��',100000,'��Ϻ','15865845569')

insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('����ˮ�⽨��3',3,'�ຣ�������Ժ','����','2013-2-3','����','���赥λһ��',100000,'��Ϻ','15865845569')

insert into Bidding(ProName,ProTypeID,ProAddress,Input,[Date],Charge,Unit,Amount,Contacts,Tel)
		values('����������·ά��4',4,'�ຣ�������Ժ','����','2013-2-3','����','���赥λһ��',100000,'��Ϻ','15865845569')


--�������͵�ID�����
--select b.*,p.[Name] as ProTypeName from Bidding as b left join ProjectType as p on b.ProTypeID=p.ID

--���������
--select b.*,p.[Name] as ProTypeName from Bidding as b left join ProjectType as p on b.ProTypeID=p.ID where b.ProName like '%%' and b.ProTypeID=2

--select * from ProjectType



