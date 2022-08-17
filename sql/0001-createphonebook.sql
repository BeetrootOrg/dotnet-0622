CREATE TABLE IF NOT EXISTS tbl_phonebook (
    id SERIAL PRIMARY KEY,
    prefixes VARCHAR(1000),
    firstname VARCHAR(1000) NOT NULL CHECK(LENGTH(firstname) > 0),
    infixes VARCHAR(1000),
    suffixes VARCHAR(1000),
    lastname VARCHAR(1000),
    patronymic VARCHAR(1000),
    codecountry VARCHAR(6),
    phonenumber VARCHAR(10) NOT NULL CHECK(LENGTH(firstname) > 2),
    typephonenumber VARCHAR(1000),
    email VARCHAR(320),
    contactgroup VARCHAR(1000)
    );