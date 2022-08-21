CREATE TABLE IF NOT EXISTS tbl_storebanktransactionsdata (
    id_transaction VARCHAR(30) PRIMARY KEY,
    id_account VARCHAR(20) NOT NULL CHECK(LENGTH(id_account) = 20),
    id_terminal VARCHAR(20) NOT NULL CHECK(LENGTH(id_terminal) = 20),
    date_transaction TIMESTAMP NOT NULL CHECK(date_transaction > NOW() - INTERVAL'30 second'),
    operation_type VARCHAR(10) NOT NULL CHECK(LENGTH(operation_type) > 4)
    );