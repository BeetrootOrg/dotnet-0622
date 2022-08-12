CREATE TABLE IF NOT EXISTS tbl_bank_transanctions_data(
    account_number SMALLINT NOT NULL,
    transaction_id BIGSERIAL,
    transaction_date_and_time TIMESTAMP NOT NULL,
    transaction_details VARCHAR(100) NOT NULL,
    transaction_sum MONEY NOT NULL,
    double_convertation BOOLEAN NOT NULL,
    balance MONEY NOT NULL
);