CREATE TABLE IF NOT EXISTS tbl_storebanktransactionsdata (
    idtransaction VARCHAR(30) PRIMARY KEY,
    idaccount VARCHAR(20) NOT NULL CHECK(LENGTH(idaccount)=20),
    idterminal VARCHAR(20) NOT NULL CHECK(LENGTH(idterminal)=20),
    datetransaction TIMESTAMP NOT NULL CHECK(datetransaction>NOW()-INTERVAL'30 second'),
    operationtype VARCHAR(10) NOT NULL CHECK(LENGTH(operationtype)>4)
    );