CREATE TABLE IF NOT EXISTS tbl_authors (
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
	date_of_birth VARCHAR(4) NOT NULL,
	date_of_death VARCHAR(4),
	biography TEXT
);