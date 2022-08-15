CREATE TABLE IF NOT EXISTS tbl_user_login_history
(
	user_name VARCHAR(150) PRIMARY KEY NOT NULL,
	computer VARCHAR(150) NOT NULL,
	client_name VARCHAR(150) NOT NULL,
	client_ip VARCHAR(15) NOT NULL,
	operating_system VARCHAR(100) NOT NULL,
	browser VARCHAR(100) NOT NULL,
	login TIMESTAMP NOT NULL,
	logout TIMESTAMP
);