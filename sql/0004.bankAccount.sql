CREATE TABLE IF NOT EXISTS tbl_bank_accounts (
   id SERIAL PRIMARY KEY,
   first_name VARCHAR(255) NOT NULL,
   last_name VARCHAR(255) NOT NULL,
   bank_account_number VARCHAR(18) NOT NULL,
   is_active BOOLEAN NOT NULL,
   secret_question VARCHAR(1000) NOT NULL,
   answer_to_secret_question VARCHAR(50) NOT NULL,
   balance MONEY DEFAULT 0
);