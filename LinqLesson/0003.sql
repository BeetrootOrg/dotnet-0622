CREATE TABLE IF NOT EXISTS tbl_bank_accounts(
    account_number SMALLINT UNIQUE,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    funds MONEY NOT NULL,
    country VARCHAR(100) NOT NULL,
    credit_limit MONEY,
    account_registry_date DATE NOT NULL
);