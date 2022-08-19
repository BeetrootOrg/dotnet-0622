CREATE TABLE IF NOT EXISTS tbl_school_schedules (
   id SERIAL PRIMARY KEY,
   grade SMALLINT NOT NULL,
   subject VARCHAR(255) NOT NULL,
   teacher_full_name VARCHAR(500) NOT NULL,
   school_period SMALLINT NOT NULL
);