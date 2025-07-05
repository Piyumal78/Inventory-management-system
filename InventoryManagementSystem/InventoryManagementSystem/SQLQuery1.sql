CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX)  NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL,
	
	
)
SELECT * FROM users;

INSERT INTO users(username, password, role, date, status) VALUES('admin', 'admin123', 'Admin','Active','2023-10-01');

 CREATE TABLE categories(
 id int PRIMARY KEY IDENTITY(1,1),
 category VARCHAR(MAX) NULL,
 date DATE NULL

 )
 SELECT * FROM categories;