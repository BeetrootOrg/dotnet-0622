CREATE TABLE IF NOT EXISTS tbl_login_history(
    login_name VARCHAR(100) NOT NULL,
    date_of_login TIMESTAMP NOT NULL,
    login_device VARCHAR(100) NOT NULL,
    login_location VARCHAR(100) NOT NULL
);