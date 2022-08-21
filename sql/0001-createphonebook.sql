CREATE TABLE IF NOT EXISTS tbl_phonebook (
    ID SERIAL PRIMARY KEY,
    prefixes VARCHAR(1000),
    first_name VARCHAR(1000) NOT NULL CHECK(LENGTH(first_name) > 0),
    infixes VARCHAR(1000),
    suffixes VARCHAR(1000),
    last_name VARCHAR(1000),
    patronymic VARCHAR(1000),
    code_country VARCHAR(6),
    phone_number VARCHAR(10) NOT NULL CHECK(LENGTH(phone_number) > 2),
    type_phone_number VARCHAR(1000),
    email VARCHAR(320),
    contact_group VARCHAR(1000)
    );