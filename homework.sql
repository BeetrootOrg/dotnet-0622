--table for ‘phone book’
CREATE TABLE IF NOT EXISTS tbl_phone_book (
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100),
	phone1 BIGINT,
    phone2 BIGINT,
	birthdate DATE,
);

--table to store school schedule
CREATE TABLE IF NOT EXISTS tbl_school_schedule (
	id SERIAL PRIMARY KEY,
	start_lesson_time TIMESTAMP NOT NULL,
    end_lesson_time TIMESTAMP NOT NULL,
    teacher VARCHAR(100) NOT NULL,
    class VARCHAR(100) NOT NULL,
    subject VARCHAR(100) NOT NULL,
);

--table to store user’s login history
CREATE TABLE IF NOT EXISTS tbl_login_history (
	id SERIAL PRIMARY KEY,
	login_time TIMESTAMPTZ NOT NULL DEFAULT now(),
    device VARCHAR(100) NOT NULL,
    ip CIDR NOT NULL,
    user_id INT NOT NULL,
);

--table to store bank accounts
CREATE TABLE IF NOT EXISTS tbl_store_bank_account (
	id SERIAL PRIMARY KEY,
	customer_first_name VARCHAR(100) NOT NULL,
    customer_last_name VARCHAR(100) NOT NULL,
    total_balance MONEY NOT NULL,
    account_created_time TIMESTAMPTZ NOT NULL,
    inn INT,
    passport_num VARCHAR (50)
);

--table to store bank transactions data
CREATE TABLE IF NOT EXISTS tbl_store_bank_account (
    id SERIAL PRIMARY KEY,
    transation_time TIMESTAMPTZ NOT NULL DEFAULT now(),
    transaction_fee_amount MONEY NOT NULL,
    transaction_currency VARCHAR (10) NOT NULL,
    exchange_rate REAL,
    transaction_amount MONEY NOT NULL,
    sender VARCHAR(100) NOT NULL,
    receiver VARCHAR (100) NOT NULL,
    senders_bank VARCHAR (100) NOT NULL,
    senders_bank_code INT NOT NULL,
    senders_account_code BIGINT NOT NULL,
);
