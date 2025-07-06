-- Create users table
CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    role VARCHAR(50),
    status VARCHAR(20),
    date DATE
);

-- Insert default admin user
INSERT INTO users (id,username, password, role, status, date)
VALUES 
('3','admin', 'admin123', 'Admin', 'Active', '2023-10-01'),
('5','test', 'admin123', 'Cashier', 'Active', '2023-10-02');



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

 CREATE TABLE categories(
 id int PRIMARY KEY IDENTITY(1,1),
 category VARCHAR(MAX) NULL,
 date DATE NULL

 )
 SELECT * FROM categories;



INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, date_insert) VALUES
('P001', 'Wireless Mouse', 'Electronics', 1500.00, 25, 'images/products/P001.jpg', 'Available', '2025-07-01'),
('P002', 'Bluetooth Headphones', 'Electronics', 4500.00, 15, 'images/products/P002.jpg', 'Available', '2025-07-02'),
('P003', 'The Great Gatsby', 'Books', 1200.00, 40, 'images/products/P003.jpg', 'Available', '2025-07-03');