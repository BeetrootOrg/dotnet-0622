CREATE TABLE IF NOT EXISTS tbl_bank_transactions (
   id SERIAL PRIMARY KEY,
   bank_account_number_from VARCHAR(18) NOT NULL,
   bank_account_number_to VARCHAR(18) NOT NULL,
   transaction_ammount MONEY NOT NULL,
   transaction_purpose VARCHAR(500)   
);