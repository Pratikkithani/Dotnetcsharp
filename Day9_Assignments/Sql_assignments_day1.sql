create database BookStoreDB
use BookStoreDB

CREATE PROCEDURE GetAllBooks
AS
BEGIN
    SELECT * FROM Books;
END;

CREATE TABLE Authors (
    AuthorID INT IDENTITY(1,1) PRIMARY KEY,    
    Name VARCHAR(100) NOT NULL,                    
    Country VARCHAR(100) NOT NULL                   
);

INSERT INTO Authors (Name, Country) VALUES 
('J.K. Rowling', 'United Kingdom'),
('George Orwell', 'United Kingdom'),
('J.R.R. Tolkien', 'United Kingdom'),
('Agatha Christie', 'United Kingdom'),
('Dan Brown', 'United States');

INSERT INTO Authors (Name, Country) VALUES 
('Dan Brown 1', 'United States');

INSERT INTO Authors (Name, Country) VALUES 
('Dan Brown 2', 'United States');

INSERT INTO Authors (Name, Country) VALUES 
('Dan Brown 3', 'United States');

select * from Authors

CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,           
    Title VARCHAR(200) NOT NULL,              
    AuthorID INT,                                   
    Price DECIMAL(10, 2) NOT NULL,                 
    PublishedYear INT NOT NULL,                     
    CONSTRAINT FK_AuthorID
	FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

INSERT INTO Books (Title, AuthorID, Price, PublishedYear) VALUES 
('Harry Potter and the Philosophers Stone', 1, 20.99, 1997),
('1984', 2, 15.49, 1949),
('The Hobbit', 3, 12.99, 1937),
('Murder on the Orient Express', 4, 9.99, 1934),
('The Da Vinci Code', 5, 19.99, 2003);

INSERT INTO Books (Title, AuthorID, Price, PublishedYear) VALUES 
('1994', 6, 15.49, 1951);


select * from Books


CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,           
    Name VARCHAR(30) NOT NULL,              
    Email VARCHAR(200) UNIQUE,                                   
    PhoneNumber VARCHAR(15) NOT NULL UNIQUE                 
);

INSERT INTO Customers (Name, Email, PhoneNumber) VALUES 
('Alice Smith', 'alice@example.com', '555-1234'),
('Bob Johnson', 'bob@example.com', '555-5678'),
('Charlie Brown', 'charlie@example.com', '555-8765'),
('David Williams', 'david@example.com', '555-4321'),
('Eva Davis', 'eva@example.com', '555-6789');

INSERT INTO Customers (Name, Email, PhoneNumber) VALUES 
('Eva Davis1', 'eva1@example.com', '555-6780')

INSERT INTO Customers (Name, Email, PhoneNumber) VALUES 
('Eva Davis2', 'eva2@example.com', '555-67801')

select * from Customers


CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,           
    CustomerID INT ,              
    OrderDate DATE NOT NULL,                                   
    TotalAmount DECIMAL(10,2) NOT NULL,                     
    CONSTRAINT FK_CustomerID
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES 
(1, '2025-03-01', 39.98),
(2, '2025-03-02', 19.99),
(3, '2025-03-03', 25.98),
(4, '2025-03-04', 9.99),
(5, '2025-03-05', 19.99);

INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES 
(1, '2025-03-01', 39.98);

select * from Orders



CREATE TABLE OrderItems (
    OrderItemID INT IDENTITY(1,1) PRIMARY KEY,    
    OrderID INT,                                   
    BookID INT,                                 
    Quantity INT NOT NULL,                    
    SubTotal DECIMAL(10, 2) NOT NULL,             
    CONSTRAINT FK_OrderID FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT FK_BookID FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

INSERT INTO OrderItems (OrderID, BookID, Quantity, SubTotal) VALUES 
(1, 1, 1, 20.99),
(1, 2, 1, 18.99),
(2, 3, 1, 12.99),
(3, 4, 1, 9.99),
(4, 5, 1, 19.99);

select  * from Customers

--1-----------------------------------------

UPDATE Books SET Price = Price * 1.10 WHERE Title='The Hobbit'

DELETE from Customers where CustomerID not in(select CustomerID from Orders)


--2-----------------------------------------

select * from Books where Price>14.29

select count(BookID) as 'Total Books' from Books

select * from Books where PublishedYear>1934 and PublishedYear<1997

select * from Customers where CustomerID in (select distinct CustomerID from Orders where CustomerID is not null)

select * from Books where Title like ('%da%')

select Max(Price) as 'Most Expensive' from Books

select * from Customers where Name like ('A%') or Name like ('J%')

select Sum(Price) as 'Total Revenue' from Books


--3-----------------------------------------

select b.Title,a.Name from Authors a join Books b on a.AuthorID=b.AuthorID

select o.OrderID,c.Name from Customers c join Orders o on c.CustomerID=o.CustomerID

select b.BookID,b.Title from  Books b left join OrderItems o  on o.BookID=b.BookID where o.OrderID is null

select c.CustomerID,c.Name,count(o.OrderID) as 'Total Orders' from Customers c join Orders o on c.CustomerID=o.CustomerID
group by c.CustomerID,c.Name
 
select o.OrderID,count(o.Quantity) 'Total Quantity',b.Title from  Books b join OrderItems o on o.BookID=b.BookID 
join Orders oo on oo.OrderID=o.OrderID
group by o.OrderID,b.Title

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID

select a.AuthorID,a.Name,a.Country from Authors a left join Books b on a.AuthorID=b.AuthorID where b.AuthorID is null

--4--------------------------------

select * from Orders o join Customers c on o.CustomerID=c.CustomerID where OrderDate in (select min(OrderDate) from Orders)

SELECT CustomerID,COUNT(OrderID) AS total_orders
FROM orders
GROUP BY CustomerID
HAVING COUNT(OrderID) = (
    SELECT MAX(order_count)
    FROM (
        SELECT COUNT(OrderID) AS order_count
        FROM orders
        GROUP BY CustomerID
    ) AS subquery
)

select * from Customers where CustomerID not in (select CustomerID from Orders)

select * from Books where Price not in (select Max(Price) from Books)

select * from Customers where CustomerID in (select sum(Price) from Books)

select * from Customers 
where CustomerID in
(select CustomerID from Orders group by CustomerID
having sum(TotalAmount) > (select avg(TotalAmount) from Orders))

--5-------------------------------

create procedure getCustomer
@CustomerID int
as
begin
	select * from Orders where CustomerID=@CustomerID
end

exec getCustomer 1

create procedure getCustomerInRange
@MinPrice DECIMAL(10, 2),
@MaxPrice DECIMAL(10, 2)
as
begin
	select * from Books where Price between @MinPrice and @MaxPrice
end

exec getCustomerInRange  14.30,100.01


--6----------------------

create view AvailableBooks 
as 
select BookID,Title,AuthorID,Price,PublishedYear from Books

select * from AvailableBooks


 
select * from Books
select * from Customers
select * from OrderItems
