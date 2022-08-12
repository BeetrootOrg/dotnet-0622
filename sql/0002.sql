-- table to store school schedule
CREATE TABLE IF NOT EXISTS tbl_school_schedule(
	day_of_week DATE NOT NULL,
	first_lesson VARCHAR(20),
    second_lesson VARCHAR(20),
    third_lesson VARCHAR(20),
    fourth_lesson VARCHAR(20),
    fifth_lesson VARCHAR(20),
    sixth_lesson VARCHAR(20),
    seventh_lesson VARCHAR(20),
    eighth_lesson VARCHAR(20)
);