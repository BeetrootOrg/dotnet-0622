CREATE DATABASE phone_book;
CREATE TABLE IF NOT EXISTS tbl_book (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	number INTEGER NOT NULL,
    note VARCHAR(100)
);

CREATE DATABASE school_schedule;
CREATE TABLE IF NOT EXISTS tbl_schedule (
	id SERIAL PRIMARY KEY,
	lesson_name VARCHAR(50),
    lesson_start TIME NOT NULL,
    lesson_end TIME NOT NULL,
    lesson_date DATE NOT NULL,
    teacher_id INTEGER NOT NULL,
    class_id INTEGER NOT NULL
);

CREATE DATABASE login_history;
CREATE TABLE IF NOT EXISTS tbl_login_history (
	id SERIAL PRIMARY KEY,
	user_name VARCHAR(100) NOT NULL,
	login_time TIME NOT NULL,
    login_date DATE NOT NULL,
    login_ip CIDR NOT NULL,
    location VARCHAR(100) NOT NULL
);

CREATE DATABASE bank_accounts;
CREATE TABLE IF NOT EXISTS tbl_accounts (
	account_id SERIAL PRIMARY KEY,
	account_name VARCHAR(50) NOT NULL,
	date_opened DATE NOT NULL,
	other_account_details VARCHAR(50),
    account_type INTEGER NOT NULL,
    costumer_id INTEGER NOT NULL,
    amount MONEY
);

CREATE DATABASE transactions_data;
CREATE TABLE IF NOT EXISTS tbl_transactions (
	transactions_id SERIAL PRIMARY KEY,
	date_transactions DATE NOT NULL,
	amount_of_transactions MONEY NOT NULL,
	purchare_id INTEGER NOT NULL,
    acoount_id INTEGER NOT NULL,
    transaction_type VARCHAR(50)
);