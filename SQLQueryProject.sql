CREATE DATABASE LoginDB;
USE LoginDB;
CREATE TABLE Menu1 (
    menu_id INT IDENTITY(1,1) PRIMARY KEY,
	product_name varchar(50),
	price numeric(18, 0),
	count numeric(18, 0),
	total numeric(18, 0),
	data varchar(50)
	);
	CREATE TABLE Users1 (
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(50)
	);
	CREATE TABLE Tables (
    table_id INT IDENTITY(1,1) PRIMARY KEY,
    receipt_id INT,
    table_number INT UNIQUE,
	FOREIGN KEY (receipt_id) REFERENCES Menu(menu_id)
	);