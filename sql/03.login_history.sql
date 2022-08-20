CREATE TABLE  IF NOT EXISTS tbl_login_history (
    id SERIAL PRIMARY KEY NOT NULL,
    user_name VARCHAR(100) NOT NULL,
	day_of_week TIMESTAMP NOT NULL,
	login_time TIME NOT NULL,
    session_time TIME NOT NULL
);