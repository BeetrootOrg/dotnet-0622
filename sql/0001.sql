CREATE TABLE IF NOT EXISTS tbl_school_schedule
(
	id SERIAL PRIMARY KEY,
	subject_name VARCHAR(150) NOT NULL,
	day_of_the_week TIMESTAMP NOT NULL,
	start_time TIME NOT NULL,
	end_time TIME NOT NULL CHECK(end_time > start_time),
	lesson_duration TIME NOT NULL DEFAULT('00:45:00'),
	number_of_lesson INTEGER NOT NULL CHECK(number_of_lesson > 0),
	class_number INTEGER NOT NULL CHECK(class_number >= 0),
	block INTEGER NOT NULL CHECK(block > 0)
);