CREATE TABLE IF NOT EXISTS tbl_bank_transactions
(
	id SERIAL PRIMARY KEY,
	routing_number VARCHAR(9) NOT NULL,
	account_number VARCHAR(16) NOT NULL,
	check_number VARCHAR(4) UNIQUE NOT NULL,
	description TEXT NOT NULL,
	transaction_date TIMESTAMP NOT NULL,
	amount MONEY NOT NULL
);