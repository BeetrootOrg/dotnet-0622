CREATE TABLE IF NOT EXISTS tbl_storebankaccounts (
    id SERIAL PRIMARY KEY,
    idaccount VARCHAR(20) NOT NULL CHECK(LENGTH(idaccount)=20),
    login VARCHAR(30) NOT NULL CHECK(LENGTH(login)>7),
    pasword VARCHAR(50) NOT NULL CHECK(LENGTH(pasword)>7),
    registrationdate TIMESTAMP NOT NULL DEFAULT NOW() CHECK(registrationdate>NOW()-INTERVAL'10 minutes'),
    passwordchangedate TIMESTAMP NOT NULL
    );