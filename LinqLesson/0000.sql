CREATE TABLE IF NOT EXISTS tbl_phonebook(
    id SERIAL PRIMARY KEY,
    First name VARCHAR(100) NOT NULL,
    Last name VARCHAR(100) NOT NULL,
    Phone number VARCHAR(17) NOT NULL,
    Operator VARCHAR(100)
);