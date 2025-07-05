SELECT * FROM categories

SELECT * FROM products

CREATE TABLE orders
(
id int PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
category VARCHAR(MAX) NULL,
qty INT NULL,
orig_price FLOAT NULL,
total_price FLOAT NULL,
order_date DATE NUll


)

SELECT * FROM orders


CREATE TABLE customers
(
id INT PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
prod_id VARCHAR(MAX) NULL,
total_price FLOAT NULL,
amount FLOAT NULL,
change FLOAT NULL,
order_date DATE NULL
)

SELECT * FROM customers

ALTER TABLE orders
ADD customer_id INT NULL

SELECT * FROM orders