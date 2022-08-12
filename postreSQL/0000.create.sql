CREATE TABLE IF NOT EXISTS tbl_persons(
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
	age SMALLINT NOT NULL,
	gender VARCHAR(1) NOT NULL,
	address VARCHAR(255)
);

INSERT INTO tbl_persons(first_name, last_name, age, gender, address)
VALUES ('FirstName1', 'LastName1', 20, 'M', 'Kyiv'),
    ('FirstName2', 'LastName2', 21, 'M', 'Kyiv'),
    ('FirstName3', 'LastName3', 22, 'M', 'Kyiv'),
    ('FirstName4', 'LastName4', 23, 'M', 'Kyiv'),
    ('FirstName5', 'LastName5', 24, 'W', 'Kyiv'),
    ('FirstName6', 'LastName6', 25, 'W', 'Kyiv'),
    ('FirstName7', 'LastName7', 25, 'W', 'Kyiv'),
    ('FirstName8', 'LastName8', 22, 'W', 'Kyiv');