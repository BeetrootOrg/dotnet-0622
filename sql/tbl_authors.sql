CREATE TABLE IF NOT EXISTS tbl_authors(
    ID SERIAL PRIMARY KEY,
    first_name VARCHAR(1000) NOT NULL,
    last_name VARCHAR(1000) NOT NULL,
    birthday TIMESTAMP
    );