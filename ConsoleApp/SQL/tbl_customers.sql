CREATE TABLE IF NOT EXISTS tbl_customers(
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100) NOT NULL
);