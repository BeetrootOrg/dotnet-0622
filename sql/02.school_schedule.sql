CREATE TABLE IF NOT EXISTS tbl_school_schedule (
    id SERIAL PRIMARY KEY,
    subject_name VARCHAR(100) NOT NULL,
	day_of_week TIMESTAMP NOT NULL,
	subject_time TIME NOT NULL,
	class_number VARCHAR(10) NOT NULL,
	classroom VARCHAR(10) NOT NULL
);