CREATE TABLE IF NOT EXISTS tbl_bank_account
(
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
    phone_number VARCHAR(15) UNIQUE NOT NULL,
    card_number VARCHAR(16) UNIQUE NOT NULL,
	address VARCHAR(255) NOT NULL,
	total_balance MONEY DEFAULT(0)
);