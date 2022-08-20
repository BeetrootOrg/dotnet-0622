CREATE TABLE  IF NOT EXISTS tbl_phone_book (
    phone_number VARCHAR(15) PRIMARY KEY NOT NULL,
    name_contact VARCHAR(100) NOT NULL,
    job VARCHAR(100),
    group_contact VARCHAR(100)
);