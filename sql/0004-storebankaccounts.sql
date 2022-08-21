CREATE TABLE IF NOT EXISTS tbl_storebankaccounts (
    ID SERIAL PRIMARY KEY,
    id_account VARCHAR(20) NOT NULL UNIQUE CHECK(LENGTH(idaccount) = 20),
    login VARCHAR(30) NOT NULL UNIQUE CHECK(LENGTH(login) > 7),
    pasword VARCHAR(50) NOT NULL CHECK(LENGTH(pasword) > 7),
    registration_date TIMESTAMP NOT NULL DEFAULT NOW() CHECK(registration_date > NOW() - INTERVAL'10 minutes'),
    password_change_date TIMESTAMP NOT NULL
    );