CREATE TABLE IF NOT EXISTS tbl_storeusersloginhistory (
    timestampact TIMESTAMP PRIMARY KEY,
    login VARCHAR(30) NOT NULL CHECK(LENGTH(login) > 2),
    access_rights VARCHAR(30) NOT NULL DEFAULT 'guest',
    inout_user BOOL NOT NULL DEFAULT TRUE,
    ip_address VARCHAR(15) NOT NULL,
    host_name VARCHAR(40) NOT NULL,
    opereation_system VARCHAR(20) NOT NULL,
    country_city VARCHAR(50) NOT NULL,
    provider VARCHAR(50) NOT NULL
    );