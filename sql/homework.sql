CREATE TABLE IF NOT EXISTS tbl_contacts 
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	number BIGINT NOT NULL,
	email VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_shedule 
(
    id SERIAL PRIMARY KEY,
    room_number SMALLINT NOT NULL,
    group_name VARCHAR (20) NOT NULL,
    subject_name VARCHAR (30) NOT NULL,
    day_name DATE NOT NULL,
    lesson_time INTERVAL NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_login_history
(
    id SERIAL PRIMARY KEY,
    user_name VARCHAR (30) NOT NULL,
    login_time TIME NOT NULL,
    logout_time TIME NOT NULL,
    login_ip VARCHAR (30) NOT NULL
);    
    
CREATE TABLE IF NOT EXISTS tbl_bank_accounts
(
    id SERIAL PRIMARY KEY,
    first_name VARCHAR (50) NOT NULL,
    second_name VARCHAR (50) NOT NULL,
    inn VARCHAR (10) NOT NULL,
    passport_data VARCHAR (30) NOT NULL,
    active_products_count SMALLINT NOT NULL,
    not_active_products_count SMALLINT NOT NULL,
    amount_of_deposit MONEY,
    amount_of_credit_card_account MONEY,
    amount_of_debit_card_account MONEY
);

CREATE TABLE IF NOT EXISTS tbl_transactons_data
(
    id SERIAL PRIMARY KEY,
    donor_inn VARCHAR (10) NOT NULL,
    recipient_inn VARCHAR (10) NOT NULL,
    start_transaction_time TIME NOT NULL,
    finish_transaction_time TIME NOT NULL,
    transacttion_amount MONEY NOT NULL
);