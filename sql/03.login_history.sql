CREATE TABLE IF NOT EXISTS tbl_login_history (
    id SERIAL PRIMARY KEY NOT NULL,
    user_name VARCHAR(100) NOT NULL,
	date_session TIMESTAMP NOT NULL,
    time_session TIME NOT NULL
);