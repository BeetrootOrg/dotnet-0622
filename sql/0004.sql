-- table to store bank accounts
CREATE TABLE IF NOT EXISTS tbl_bank_accounts(
    bank_account_id VARCHAR(16) RPIMARY KEY,
	fist_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    currency_type VARCHAR(20) NOT NULL,
    currency_amount MONEY
);
