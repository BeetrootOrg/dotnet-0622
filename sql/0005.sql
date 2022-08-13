-- table to store bank transactions data
CREATE TABLE IF NOT EXISTS tbl_bank_transactions(
    transaction_id VARCHAR(20) RPIMARY KEY,
    from_account_id VARCHAR(16) NOT NULL,
	to_account_id VARCHAR(16) NOT NULL,
    currency_type VARCHAR(20) NOT NULL,
    currency_amount MONEY NOT NULL,
    transaction_description VARCHAR(255)
);