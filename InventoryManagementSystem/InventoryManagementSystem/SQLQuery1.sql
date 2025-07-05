CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX)  NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL,
	
	
)

INSERT INTO users(username, password,role,status) VALUES('testing1', 'admin123'.'Cashier','Active');
SELECT * FROM users;

DELETE FROM users WHERE id=9;

INSERT INTO users(id,username, password, role, status, date) VALUES('1','admin', 'admin123', 'Admin','Active','2023-10-01');

 CREATE TABLE categories(
 id int PRIMARY KEY IDENTITY(1,1),
 category VARCHAR(MAX) NULL,
 date DATE NULL

 )
 SELECT * FROM categories;