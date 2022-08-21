CREATE TABLE IF NOT EXISTS tbl_customers(
    ID SERIAL PRIMARY KEY,
    id_account VARCHAR(25) NOT NULL UNIQUE,
    first_name VARCHAR(1000) NOT NULL,
    last_name VARCHAR(1000) NOT NULL,
    birthday TIMESTAMP NOT NULL,
    sex BOOLEAN
    );