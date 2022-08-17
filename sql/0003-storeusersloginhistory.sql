CREATE TABLE IF NOT EXISTS tbl_storeusersloginhistory (
    timestampact TIMESTAMP PRIMARY KEY,
    login VARCHAR(30) NOT NULL CHECK(LENGTH(login) > 2),
    accessrights VARCHAR(30) NOT NULL DEFAULT 'guest',
    inoutuser BOOL NOT NULL DEFAULT TRUE,
    ipaddress VARCHAR(15) NOT NULL,
    hostname VARCHAR(40) NOT NULL,
    opereationsystem VARCHAR(20) NOT NULL,
    countrycity VARCHAR(50) NOT NULL,
    provider VARCHAR(50) NOT NULL
    );