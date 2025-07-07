-- Create users table
CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    role VARCHAR(50),
    status VARCHAR(20),
    date DATE
);

SELECT * FROM customers;

SELECT COUNT(id) FROM customers;


-- Insert default admin user
INSERT INTO users (username, password, role, status, date)
VALUES 
('admin', 'admin123', 'Admin', 'Active', '2023-10-01'),
('test', 'admin123', 'Cashier', 'Active', '2023-10-02');



-- Create categories table
CREATE TABLE categories (
    id INT PRIMARY KEY IDENTITY(1,1),
    category VARCHAR(100) NOT NULL,
    date DATE NOT NULL DEFAULT GETDATE()
);

-- Select queries to verify table creation
SELECT * FROM users;
SELECT * FROM categories;

CREATE TABLE products
(
id INT PRIMARY KEY IDENTITY(1,1),
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
category VARCHAR(MAX) NULL,
price FLOAT NULL,
stock INT NULL,
image_path VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_insert DATE NULL       
    
)

<<<<<<< HEAD
SELECT * FROM products;
INSERT INTO categories (category) VALUES 
('Electronics'),
('Books'),
('Clothing'),
('Gadgets'),
('Home Appliances'),
('Sports Equipment'),
('Office Supplies'),
('Toys'),
('Beauty Products'),
('Groceries');
=======
 CREATE TABLE categories(
 id int PRIMARY KEY IDENTITY(1,1),
 category VARCHAR(MAX) NULL,
 date DATE NULL

 )
 SELECT * FROM categories;
>>>>>>> e1394d15b6bf62968fdade6b695c0bf011329132
