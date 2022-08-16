CREATE TABLE IF NOT EXISTS tbl_storeusersloginhistory (
    timestampact TIMESTAMP PRIMARY KEY,
    login VARCHAR(30) NOT NULL CHECK(LENGTH(login)>2),
    accessrights VARCHAR(30) NOT NULL DEFAULT 'guest',
    online BOOL NOT NULL DEFAULT TRUE
    );