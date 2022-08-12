-- table to store user’s login history
CREATE TABLE IF NOT EXISTS tbl_login_history(
	user_name VARCHAR(20) NOT NULL,
    login_time TIMESTAMPTZ NOT NULL
);