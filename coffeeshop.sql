--create database CoffeeShopR;

--create table item(itemid int identity(1,1) , itemname varchar(50) , price float ,PRIMARY KEY (itemid) );

--insert into item (itemname,price) values ('Black',120);
--insert into item (itemname,price) values ('Cold',100);
--insert into item (itemname,price) values ('Hot',120);

--create table customer(customerid int identity(1,1) , customername varchar(50) , addresss varchar(50), contact varchar(50),PRIMARY KEY (customerid));

--insert into customer (customername,addresss,contact) values ('Arafat Bin Reza','Mirpur-13','01625420852');
--insert into customer (customername,addresss,contact) values ('Rezwana Binte Reza','Mirpur-1','01676234640');
--insert into customer (customername,addresss,contact) values ('Rezaul Karim','Mirpur-2','01721359359');

--create table orders(orderid int identity(1,1) , quantity int , totalprice float ,customerid int,itemid int, PRIMARY KEY (orderid),FOREIGN KEY (customerid) REFERENCES customer(customerid),FOREIGN KEY (itemid) REFERENCES item(itemid));

create table customers(id int identity(1,1),customername varchar(50),contact varchar(50),adrs varchar(50));


--delete from customers where id=2; 
--update customers set customername='Arafat Bin Reza',adrs='Mirpur-13',contact='01625420852';
select*from customers



create table items(id int identity(1,1),itemname varchar(50),price float);

create table orders(id int identity(1,1),quantity int,totalPrice float,customername varchar(50),itemname varchar(50));
