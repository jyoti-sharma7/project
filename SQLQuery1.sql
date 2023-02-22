create database Electronic

 use Electronic;
 drop table login_user

 create table login_user(
 username varchar(100) not null primary key,
 password varchar(100) not null 
 )
 insert into login_user
 values('Radha','radha12')
 insert into login_user
 values('sachet','sachet12')
 
 select * from login_user
drop table User_registration

 select * from User_registration 
 create table User_registration(
 Userid int primary key identity(1,1),
 Fullname varchar(100) not null,
 Username varchar(100) unique,
 Password varchar(100) not null,
 Contact varchar(30) not null,
 Address varchar(100) not null,
 Email varchar(100) not null,
 Gender varchar(100),
 Age int not null)
 
)
select * from User_registration
  alter table User_registration

  insert into User_registration
  values('Bhanu Mahato','Bhanu','bhanu','9843122182','Chanauli','bhanu@gmail.com','Female',20)
   insert into User_registration
  values('Ram Krishna Sharma','Ram','ram','9843122142','Chanauli','ram@gmail.com','Male',20)
create table product_add(
Productid int primary key identity(1,1),
Productname varchar(100) not null,
Brand varchar(100) not null,
Quantity int not null,
Price int not null) 
select * from product_add


create table customer_add(
Customerid int primary key identity(1,1),
CustomerName varchar(100) not null,
Address varchar(100) not null,
Phone varchar(100) not null
)
select * from customer_add
drop table purchase_add
create table purchase_add(
Purchaseid int primary key identity(1,1),
SupplierName varchar(100) not null,
pPhone varchar(100) not null,
pItems varchar(100) not null,
pBrand varchar(100) not null,
pQuantity varchar(100) not null,
pPrice varchar(100) not null)

select * from purchase_add

create table Purchase_return(
PurchaseReturnid int primary key identity(1,1),
rPurchaseid int,
rItems varchar(100) not null,
rBrand varchar(100) not null,
rQuantity int not null,
rPrice int not null
foreign key(rPurchaseid) references purchase_add(Purchaseid))

insert into Purchase_return
values(1,'Fan','Bajaj',1,19000)


 drop table Purchase_return

 select * from Purchase_return
 drop table Sales

 create table Sales(
 Salesid int primary key identity(1,1),
 cid int not null,
 Items varchar(100) not null,
 Dateofsales date not null,
 sBrand varchar(100),
 sQuantity int not null,
 sPrice int not null
 foreign key(cid) references customer_add(Customerid))
 
 
 
 select * from Sales

 drop table Sales_Return

 create table Sales_Return(
 SalesReturnid int primary key identity(1,1),
 salesid int,
 DateOfReturn date,
 rItems varchar(100),
 rBrand varchar(100),
 rQuantity int,
 rPrice int
 foreign key(salesid) references Sales(Salesid)
)
 

 select * from customer_add
 select * from Sales
 select * from Sales_Return
 select SalesReturnid,CustomerName,DateOfReturn,rItems from Sales_Return join Sales on Sales_Return.salesid=Sales.Salesid join customer_add on Sales.cid=customer_add.Customerid