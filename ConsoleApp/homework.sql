CREATE TABLE IF NOT EXISTS tbl_phone_book (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    country_code VARCHAR(5) NOT NULL,
    phone_number integer NOT NULL CONSTRAINT positive_phone_number CHECK (phone_number > 0),
    email VARCHAR (50)
)

CREATE TABLE IF NOT EXISTS tbl_school_schedule (
    id SERIAL PRIMARY KEY,
    first_lesson VARCHAR(50) NOT NULL,
    second_lesson VARCHAR(50) NOT NULL,
    third_lesson VARCHAR(50) NOT NULL,
    forth_lesson VARCHAR(50) NOT NULL,
    fifth_lesson VARCHAR(50) NOT NULL,
    sixth_lesson VARCHAR(50) NOT NULL,
    lesson_break TIME NOT NULL,
    day_of_week DATE NOT NULL,
)

CREATE TABLE IF NOT EXISTS tbl_user_login_history (
    id SERIAL PRIMARY KEY,
    name VARCHAR (50) NOT NULL,
    login_time TIMESTAMPTZ NOT NULL,
)

CREATE TABLE IF NOT EXISTS tbl_user_bank_account (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    verified BOOLEAN NOT NULL,
    total_balance MONEY,
    address VARCHAR (50)
)

CREATE TABLE IF NOT EXISTS tbl_bank_transactions_data (
    id SERIAL PRIMARY KEY,
    transaction_amount MONEY,
    transaction_fee MONEY,
    currency VARCHAR (10) NOT NULL,
    transaction_from VARCHAR (50) NOT NULL,
    transaction_to VARCHAR (50) NOT NULL,
)