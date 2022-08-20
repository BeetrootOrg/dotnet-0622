CREATE TABLE IF NOT EXISTS tbl_school_schedule (
    id SERIAL PRIMARY KEY,
    subject_name VARCHAR(100) NOT NULL,
	subject_date TIMESTAMP NOT NULL,
	class VARCHAR(10) NOT NULL,
	classroom VARCHAR(10) NOT NULL
);