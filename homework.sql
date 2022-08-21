CREATE TABLE IF NOT EXISTS tbl_phonebook(
  id SERIAL PRIMARY KEY,
  first_name VARCHAR(100) NOT NULL,
  last_name VARCHAR(100) NOT NULL,
    address VARCHAR(100) NOT NULL,
    phone_number VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_school(
    class_number SMALLINT PRIMARY KEY NOT NULL,
    date DATE NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    subject VARCHAR(100) NOT NULL,
    group_number SMALLINT NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_logingistory(
    id SERIAL PRIMARY KEY,
    login VARCHAR(20) NOT NULL,
    login_date DATE,
    logout_date DATE
);

CREATE TABLE IF NOT EXISTS tbl_bankaccounts(
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    bankaccount_number INTEGER NOT NULL,
    bankaccount_money MONEY
);

CREATE TABLE IF NOT EXISTS tbl_transaction(
    id SERIAL PRIMARY KEY,
    sender_id INTEGER NOT NULL,
    recieve_id INTEGER NOT NULL,
    send_date DATE NOT NULL,
    recieve_date DATE NOT NULL,
    isreceive BOOL NOT NULL DEFAULT FALSE 
);