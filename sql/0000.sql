CREATE TABLE IF NOT EXISTS tbl_phonebook(
    first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
    address VARCHAR(100) NOT NULL,
    phone_number VARCHAR(50) PRIMARY KEY NOT NULL,
    email VARCHAR(100)
)

CREATE TABLE IF NOT EXISTS tbl_schedule(
    class_id SERIAL PRIMARY KEY,
    date DATE NOT NULL,
    lesson_one VARCHAR(50),
    lesson_two VARCHAR(50),
    lesson_three VARCHAR(50),
    lesson_four VARCHAR(50)
)

CREATE TABLE IF NOT EXISTS tbl_login(
    user_name VARCHAR(50) NOT NULL,
    date DATE NOT NULL,
    login TIMESTAMP NOT NULL,
    logout TIMESTAMP NOT NULL
)

CREATE TABLE IF NOT EXISTS tbl_bank_account (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    vip_status BOOLEAN NOT NULL,
    total_balance MONEY,
    last_login TIMESTAMP NOT NULL
)

CREATE TABLE IF NOT EXISTS tbl_transactions_data (
    id SERIAL PRIMARY KEY,
    iban_from VARCHAR(29) NOT NULL,
    iban_to VARCHAR(29) NOT NULL,
    amount MONEY NOT NULL
)