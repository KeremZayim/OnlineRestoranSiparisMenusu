CREATE DATABASE Restoran;
use Restoran;

CREATE TABLE dbo.users (
    user_id INT PRIMARY KEY NOT NULL,
    user_type NCHAR(50) NOT NULL,
    username NCHAR(50) NOT NULL,
    password NCHAR(50) NOT NULL,
    name NCHAR(30) NOT NULL,
    surname NCHAR(30) NOT NULL
);

CREATE TABLE dbo.foods (
    food_id INT PRIMARY KEY NOT NULL,
    food_name NCHAR(100) NOT NULL,
    category_id INT NOT NULL,
    diet_type_id INT NOT NULL,
    food_calorie FLOAT,
    food_picture NVARCHAR(MAX),
    food_price DECIMAL(10, 2),
    FOREIGN KEY (category_id) REFERENCES dbo.categories(category_id) ON DELETE CASCADE,
    FOREIGN KEY (diet_type_id) REFERENCES dbo.diet_types(diet_type_id) ON DELETE CASCADE
);

CREATE TABLE dbo.foods_allergens (
    food_id INT NOT NULL,
    allergen_id INT NOT NULL,
    PRIMARY KEY (food_id, allergen_id),
    FOREIGN KEY (food_id) REFERENCES dbo.foods(food_id) ON DELETE CASCADE,
    FOREIGN KEY (allergen_id) REFERENCES dbo.allergens(allergen_id) ON DELETE CASCADE
);

CREATE TABLE dbo.order_details (
    order_detail_id INT PRIMARY KEY NOT NULL,
    order_id INT NOT NULL,
    food_id INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (order_id) REFERENCES dbo.orders(order_id) ON DELETE CASCADE,
    FOREIGN KEY (food_id) REFERENCES dbo.foods(food_id) ON DELETE CASCADE
);

CREATE TABLE dbo.orders (
    order_id INT PRIMARY KEY NOT NULL,
    user_id INT NOT NULL,
    order_date DATETIME NOT NULL,
    FOREIGN KEY (user_id) REFERENCES dbo.users(user_id) ON DELETE CASCADE
);

CREATE TABLE dbo.allergens (
    allergen_id INT PRIMARY KEY NOT NULL,
    allergen_name NCHAR(20) NOT NULL
);

CREATE TABLE dbo.categories (
    category_id INT PRIMARY KEY NOT NULL,
    category_name NCHAR(30) NOT NULL
);

CREATE TABLE dbo.diet_types (
    diet_type_id INT PRIMARY KEY NOT NULL,
    diet_type_name NCHAR(20) NOT NULL
);

CREATE TABLE dbo.drinks (
    drink_id INT PRIMARY KEY NOT NULL,
    drink_name NCHAR(20) NOT NULL,
    drink_category_id INT NOT NULL,
    drink_calorie INT NOT NULL,
    drink_picture IMAGE NOT NULL,
    drink_price INT NOT NULL
);
