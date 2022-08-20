CREATE TABLE IF NOT EXISTS tbl_transactions_data (
    id SERIAL PRIMARY KEY,
	card_number VARCHAR(16) UNIQUE NOT NULL,
	check_number VARCHAR(16) UNIQUE NOT NULL,
    currency VARCHAR (10) NOT NULL,
    sender VARCHAR (100),
    recipient VARCHAR (100) NOT NULL,
	description TEXT NOT NULL,
	transaction_date TIMESTAMP NOT NULL,
	transaction_amount MONEY NOT NULL
)