-- table for ‘phone book’
CREATE TABLE IF NOT EXISTS tbl_phone_book(
	first_name VARCHAR(20) NOT NULL,
	last_name VARCHAR(20),
	phone_number VARCHAR(15) NOT NULL,
    phone_number_extra VARCHAR(15)
);